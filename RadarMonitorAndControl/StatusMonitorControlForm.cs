using AlarmFunction;
using Common;
using DataBaseOperate;
using DataCurveDisplay;
using RadarMonitorAndControl.Properties;
using SerialPortComm;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Lrdm = LocalRadarDataModels;
using Tm = System.Timers;

namespace RadarMonitorAndControl
{
    public partial class StatusMonitorControlForm : Form
    {
        private SerialPortOperate _serialPort;
        private readonly SoundAlarm _soundAlarm = new SoundAlarm();
        private readonly SynchronizationContext _synchContext;
        private readonly Tm.Timer _tmr = new Tm.Timer();
        private readonly Tm.Timer _tmrControl = new Tm.Timer();
        private readonly PowerAlarmParameter _powerAlarmPara = new PowerAlarmParameter();
        private string _conn;
        private bool _debugmode;
        private bool _isCollect;
        //xprivate bool isContinueKeyUp = false;
        //xprivate bool isfirsControlcmd = false;

        public StatusMonitorControlForm()
        {
            InitializeComponent();
            _synchContext = SynchronizationContext.Current;
            _tmr.Interval = 1000;
            _tmr.Elapsed += tmr_Elapsed;
            _tmrControl.Interval = 8000;
            _tmrControl.Elapsed += tmrControl_Elapsed;
            _tmrControl.Stop();
        }

        public bool CanClose { get; set; }

        public CommonPara Para { get; set; }

        public string StationId { get; set; }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (CanClose)
            {
                base.OnFormClosing(e);
            }
            else
            {
                if (!Para.StationGrade.Contains("台站")) return;
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                }
                else
                {
                    _serialPort?.ClosePort();
                }
            }
        }

        private void PowerAlarm(DateTime dt, PowerDataTable nowpowerData, PowerDataTable prepowerData)
        {
            DataAdapter dataAdapter = new DataAdapter(StationId, dt);
            RadarPower powerDataNow = dataAdapter.DataResolve(nowpowerData);
            RadarPower powerDataPre = dataAdapter.DataResolve(prepowerData);
            PowerValueJumpAlarm powerCheckAlarm = new PowerValueJumpAlarm(powerDataPre, powerDataNow, _powerAlarmPara.PowerEnable, _powerAlarmPara.PowerAlarm);
            powerCheckAlarm.CheckPowerAlarm();
            _synchContext.Post(a => powerIndicationUI.SetBackColor(powerCheckAlarm.CheckResultList), null);
        }

        private void RadarFailureAlarm(AlarmData alarmData)
        {
            _synchContext.Post(a =>
            {
                try
                {
                    RadarAlarm radarAlarm = new RadarAlarm();
                    bool isalarm = radarAlarm.ProcessAlarm(alarmData);
                    if (isalarm)
                    {
                        if (报警声音ToolStripMenuItem.Checked && _isCollect)
                        {
                            _soundAlarm.StartAlarm(AppDomain.CurrentDomain.BaseDirectory + "Alarm.wav");
                        }
                        toolStripStatusLabel1.Image = Resources.red_light;
                        Activate();
                    }
                    else
                    {
                        toolStripStatusLabel1.Image = Resources.green_light;
                    }
                }
                catch (Exception ex)
                {
                    CommonLogHelper.GetInstance("LogError").Error(@"雷达故障报警过程出错", ex);
                }
            }, null);
        }

        private void RecDataProcessing(byte[] message)
        {
            Thread newThread = new Thread((ThreadStart)delegate
            {
                try
                {
                    if (message.Length <= 4)
                    { CommonLogHelper.GetInstance("LogInfo").Info(@"未接收到采集数据"); return; }
                    if (message[0] != Convert.ToByte("7E", 16))
                    { return; }
                    if (message[1] != Convert.ToByte("D1", 16))
                    { return; }
                    string m = message[4].ToString("X2");
                    switch (m)
                    {
                        case "03":

                            #region 获取到的状态、报警、电压数据处理

                            _synchContext.Post(a => { tSSLSystemStatus.Text = @"获取最新数据成功"; }, null);
                            DateTime dt = DateTime.Now;
                            DateTime obdt = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, 0);
                            DataAdapter dataadp = new DataAdapter(StationId, obdt);
                            try
                            {
                                string msg = string.Join(" ", message.Select(x => x.ToString("X2")).ToArray());
                                CommonLogHelper.GetInstance("LogInfo").Info($@"接收到采集数据：{msg}");
                                dataadp.DataResolve(message);
                                _synchContext.Post(a =>
                                    {
                                        try
                                        {
                                            radarStatusUI.SetAlarmStatus(dataadp.AlarmStatusData);
                                            radarControlUI.SetControlStatus(dataadp.ControlStatusData);
                                            powerIndicationUI.SetPowerDataValue(dataadp.RadarPowerData);
                                            tSSLDataUpdateTime.Text = $"数据更新时间：{obdt.ToString("yyyy-MM-dd HH:mm")}";
                                        }
                                        catch (Exception ex)
                                        {
                                            CommonLogHelper.GetInstance("LogError").Error(@"数据显示到界面上出错", ex);
                                        }
                                    }, null);

                                RadarFailureAlarm(dataadp.AlarmStatusData);
                            }
                            catch (Exception e)
                            {
                                CommonLogHelper.GetInstance("LogError").Error(@"接收处理数据并显示过程出错", e);
                            }

                            if (_isCollect)
                            {
                                AlarmStatusTable alarmStatus = dataadp.DataResolve(dataadp.AlarmStatusData);
                                ControlStatusTable controlStatus = dataadp.DataResolve(dataadp.ControlStatusData);
                                PowerDataTable powerData = dataadp.DataResolve(dataadp.RadarPowerData);

                                try
                                {
                                    DataBaseHelper dbHelper = new DataBaseHelper(_conn);
                                    dbHelper.AlarmStatusInsert(alarmStatus);
                                    dbHelper.ControlStatusInsert(controlStatus);
                                    dbHelper.PowerDataInsert(powerData);
                                    dbHelper.SaveChanges();
                                    CommonLogHelper.GetInstance("LogInfo").Info(@"数据入库成功");
                                }
                                catch (Exception e)
                                {
                                    CommonLogHelper.GetInstance("LogError").Error(@"数据入库过程出错", e);
                                    try
                                    {
                                        Lrdm.AlarmStatusModels localalarmStatus = dataadp.LocalDataResolve(dataadp.AlarmStatusData);
                                        Lrdm.ControlStatusModels localcontrolStatus = dataadp.LocalDataResolve(dataadp.ControlStatusData);
                                        Lrdm.PowerDataModels localpowerData = dataadp.LocalDataResolve(dataadp.RadarPowerData);

                                        DataBaseHelper dbHelper = new DataBaseHelper();
                                        dbHelper.AlarmStatusInsert(localalarmStatus);
                                        dbHelper.ControlStatusInsert(localcontrolStatus);
                                        dbHelper.PowerDataInsert(localpowerData);
                                        CommonLogHelper.GetInstance("LogInfo").Info(@"数据入本地库成功");
                                    }
                                    catch (Exception exception)
                                    {
                                        CommonLogHelper.GetInstance("LogError").Error(@"数据入本地库过程出错", exception);
                                    }
                                }

                                try
                                {
                                    RadarDataClassesDataContext radarDataContext = new RadarDataClassesDataContext(_conn);
                                    PowerDataTable prepowerData =
                                            radarDataContext.PowerDataTable.First(
                                                x =>
                                                    x.DateTime == dt.AddMinutes(-Para.UpdateDataIntl) &&
                                                    x.StationID == StationId);
                                    PowerAlarm(obdt, powerData, prepowerData);
                                }
                                catch (Exception ex)
                                {
                                    CommonLogHelper.GetInstance("LogError").Error(@"电源跳变检查报警过程出错", ex);
                                }
                            }

                            #endregion 获取到的状态、报警、电压数据处理

                            break;

                        case "81":
                            string controlmsg = string.Join(" ", message.Select(x => x.ToString("X2")).ToArray());
                            CommonLogHelper.GetInstance("LogInfo").Info($@"接收到控制数据：{controlmsg}");
                            //isContinueKeyUp = isfirsControlcmd;
                            break;
                    }
                }
                catch (Exception e)
                {
                    CommonLogHelper.GetInstance("LogError").Error(_isCollect ? @"接收处理数据并入库过程出错" : @"接收处理数据并显示过程出错", e);
                }
                finally
                {
                    _isCollect = false;
                    _synchContext.Post(a => { tSSLSystemStatus.Text = radarControlUI.Enabled ? @"正在使用控制功能" : @"等待采集数据"; }, null);
                }
            })
            { IsBackground = true };
            newThread.Start();
        }

        private void SendControlCmd(string cmd1, string cmd2)
        {
            Thread controlThread2 = new Thread((ThreadStart)delegate
            {
                try
                {
                    string pwd = "88 88 88 88 88 88 88 88";
                    byte[] cmdbyte = SerialPortCmdCombine.SetBaseCommand("FF", pwd, "81", cmd1);
                    CommonLogHelper.GetInstance("LogInfo").Info(
                        $@"发送控制命令1：{string.Join(" ", cmdbyte.Select(x => x.ToString("X2")).ToArray())}");
                    //isfirsControlcmd = true;
                    _serialPort.SendCommand(cmdbyte);
                    //while (!isContinueKeyUp)
                    //{
                    //    //SpinWait.SpinUntil(() => isContinueKeyUp);
                    //}
                    Thread.Sleep(1200);
                    //Thread.SpinWait(1200);
                    //isfirsControlcmd = false;
                    //isContinueKeyUp = false;
                    byte[] cmdbyte2 = SerialPortCmdCombine.SetBaseCommand("FF", pwd, "81", cmd2);
                    CommonLogHelper.GetInstance("LogInfo").Info(
                        $@"发送控制命令2：{string.Join(" ", cmdbyte2.Select(x => x.ToString("X2")).ToArray())}");
                    _serialPort.SendCommand(cmdbyte2);
                    _tmrControl.Start();
                    MessageBox.Show(@"发送控制指令成功，等待8秒后更新界面", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //返回状态更新界面
                }
                catch (Exception ex)
                {
                    CommonLogHelper.GetInstance("LogError").Error(@"发送控制命令过程出错", ex);
                    MessageBox.Show(@"发送控制命令过程出错，" + ex.Message, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            })
            { IsBackground = true };
            controlThread2.Start();
        }

        private void StatusMonitorControlForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.D) && e.Alt)
            {
                AdminForm adminForm = new AdminForm();
                adminForm.EnableControl += () =>
                {
                    _debugmode = true;
                    CommonLogHelper.GetInstance("LogInfo").Info(@"启用了终端调试功能");
                };
                adminForm.ShowDialog();
            }
            if (_debugmode)
            {
                DebugForm debugForm = new DebugForm
                {
                    ThisSerialPort = _serialPort
                };
                debugForm.ShowDialog();
                _debugmode = false;
            }
        }

        private void StatusMonitorControlForm_Load(object sender, EventArgs e)
        {
            _serialPort = new SerialPortOperate(Para.SerialPortPara.PortName, Para.SerialPortPara.BaudRate, Para.SerialPortPara.DataBits, Para.SerialPortPara.StopBits, "NONE");
            try
            {
                _serialPort.OpenPort();
            }
            catch (Exception exception)
            {
                CommonLogHelper.GetInstance("LogError").Error($"打开串口{Para.SerialPortPara.PortName}出错", exception);
                MessageBox.Show($"打开串口{Para.SerialPortPara.PortName}出错");
            }

            try
            {
                _powerAlarmPara.GetXmlNodeInfo();
            }
            catch (Exception ex)
            {
                CommonLogHelper.GetInstance("LogError").Error(@"读取电源报警参数出错", ex);
            }

            try
            {
                Text = StationId + @"：雷达状态监控和控制";
                _conn =
                    $"Data Source={Para.SqlServerPara.SqlIp};Initial Catalog={Para.SqlServerPara.SqlDb};User ID={Para.SqlServerPara.SqlUser};Password={Para.SqlServerPara.SqlPwd};";

                powerIndicationUI.StationId = StationId;
                powerIndicationUI.SqlConnection = _conn;

                if (Para.StationGrade.Contains("台站"))
                {
                    启用控制ToolStripMenuItem.Visible = true;
                    _serialPort.ReturnCollectorRecData += RecDataProcessing;
                    radarControlUI.SendCmd += SendControlCmd;
                }
                DateTime dt = DateTime.Now;
                int s = dt.Second;
                dt = dt.AddSeconds(-s);
                if (Para.StationGrade.Contains("台站"))
                {
                    dt = s < 30 ? dt.AddSeconds(30) : dt.AddSeconds(30).AddMinutes(Para.UpdateDataIntl);
                }
                else
                {
                    dt = dt.Second < 30 ? dt.AddSeconds(45) : dt.AddSeconds(45).AddMinutes(Para.UpdateDataIntl);
                }
                toolSslNextUpdateTime.Text = $"下次采集时间：{dt.ToString("yyyy-MM-dd HH:mm:ss")}";
                _tmr.Start();
            }
            catch (Exception ex)
            {
                CommonLogHelper.GetInstance("LogError").Error(@"加载窗体过程出错", ex);
            }
        }

        private void tmr_Elapsed(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DateTime obdt = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, 0);
            if (dt.Minute % Para.UpdateDataIntl == 0 && dt.Second == 30)
            {
                #region 台站级别发送指令

                if (Para.StationGrade.Contains("台站"))
                {
                    Thread collectTimeThread = new Thread((ThreadStart)delegate
                   {
                       try
                       {
                           _synchContext.Post(a =>
                           {
                               toolSslNextUpdateTime.Text =
                                   $"下次采集时间：{obdt.AddSeconds(30).AddMinutes(Para.UpdateDataIntl).ToString("yyyy-MM-dd HH:mm:ss")}";
                               tSSLSystemStatus.Text = @"正在获取最新数据";
                           }, null);
                           byte[] cmd = SerialPortCmdCombine.SetBaseCommand("FF", "03");
                           CommonLogHelper.GetInstance("LogInfo")
                                   .Info($@"发送定时采集命令：{string.Join(" ", cmd.Select(x => x.ToString("X2")).ToArray())}");
                           _isCollect = true;
                           _serialPort.SendCommand(cmd);
                       }
                       catch (Exception ex)
                       {
                           CommonLogHelper.GetInstance("LogInfo").Info(@"发送串口命令获取数据过程出错");
                           CommonLogHelper.GetInstance("LogError").Error(@"发送串口命令获取数据过程出错", ex);
                       }
                   })
                    { IsBackground = true };
                    collectTimeThread.Start();
                }

                #endregion 台站级别发送指令
            }
            if (dt.Second == 40)
            {
                #region 停止声音报警

                _soundAlarm.StopAlarm();

                #endregion 停止声音报警
            }
            if (dt.Minute % Para.UpdateDataIntl == 0 && dt.Second == 45)
            {
                #region 省级级别操作数据库

                if (Para.StationGrade.Contains("省级"))
                {
                    Thread collectProThread = new Thread((ThreadStart)delegate
                   {
                       try
                       {
                           bool havePowerData = false;
                           tSSLSystemStatus.Text = @"获取最新数据";
                           RadarDataClassesDataContext radarDataContext = new RadarDataClassesDataContext(_conn);
                           DataAdapter dataadp = new DataAdapter(StationId, obdt);
                           dataadp.DataResolve(radarDataContext);
                           _synchContext.Post(a =>
                           {
                               toolSslNextUpdateTime.Text =
                                   $"下次采集时间：{obdt.AddSeconds(45).AddMinutes(Para.UpdateDataIntl).ToString("yyyy-MM-dd HH:mm:ss")}";
                               try
                               {
                                   if (dataadp.AlarmStatusData != null)
                                   {
                                       radarStatusUI.SetAlarmStatus(dataadp.AlarmStatusData);
                                   }
                                   else
                                   {
                                       CommonLogHelper.GetInstance("LogInfo").Error(@"无当前报警数据");
                                   }
                                   if (dataadp.ControlStatusData != null)
                                   {
                                       radarControlUI.SetControlStatus(dataadp.ControlStatusData);
                                   }
                                   else
                                   {
                                       CommonLogHelper.GetInstance("LogInfo").Error(@"无当前状态数据");
                                   }
                                   if (dataadp.RadarPowerData != null)
                                   {
                                       powerIndicationUI.SetPowerDataValue(dataadp.RadarPowerData);
                                       havePowerData = true;
                                   }
                                   else
                                   {
                                       CommonLogHelper.GetInstance("LogInfo").Error(@"无当前电源数据");
                                   }
                                   if (dataadp.AlarmStatusData != null || dataadp.ControlStatusData != null || dataadp.RadarPowerData != null)
                                   {
                                       tSSLDataUpdateTime.Text = $"数据更新时间：{obdt.ToString("yyyy-MM-dd HH:mm")}";
                                   }
                               }
                               catch (Exception ex)
                               {
                                   CommonLogHelper.GetInstance("LogError").Error(@"数据显示到界面上出错", ex);
                               }
                           }, null);
                           CommonLogHelper.GetInstance("LogInfo").Info(@"获取数据库数据成功");

                           try
                           {
                               RadarFailureAlarm(dataadp.AlarmStatusData);
                           }
                           catch (Exception ex)
                           {
                               CommonLogHelper.GetInstance("LogError").Error(@"雷达故障报警过程出错", ex);
                           }

                           try
                           {
                               if (havePowerData)
                               {
                                   PowerDataTable nowpowerData =
                                           radarDataContext.PowerDataTable.First(x => x.DateTime == dt && x.StationID == StationId);
                                   PowerDataTable prepowerData =
                                           radarDataContext.PowerDataTable.First(
                                               x =>
                                                   x.DateTime == dt.AddMinutes(-Para.UpdateDataIntl) &&
                                                   x.StationID == StationId);
                                   PowerAlarm(obdt, nowpowerData, prepowerData);
                               }
                           }
                           catch (Exception ex)
                           {
                               CommonLogHelper.GetInstance("LogError").Error(@"电源跳变检查过程出错", ex);
                           }
                       }
                       catch (Exception ex)
                       {
                           CommonLogHelper.GetInstance("LogError").Error(@"提取数据库数据处理过程出错", ex);
                       }
                   })
                    { IsBackground = true };
                    collectProThread.Start();
                }

                #endregion 省级级别操作数据库
            }
            if (dt.Minute % 5 == 0 && dt.Second == 50)
            {
                #region 正常入库失败后批量数据补入

                Thread batchDataProcessThread = new Thread((ThreadStart)delegate
               {
                   bool dbisAvaliable = true;
                   try
                   {
                       RadarDataClassesDataContext radarDataContext = new RadarDataClassesDataContext(_conn);
                       radarDataContext.Connection.Open();
                       radarDataContext.Connection.Close();
                   }
                   catch (Exception)
                   {
                       dbisAvaliable = false;
                   }
                   if (dbisAvaliable)
                   {
                       DataBaseHelper dbHelper = new DataBaseHelper(_conn);
                       try
                       {
                           DataAdapter dataAdapter = new DataAdapter();
                           CommonLogHelper.GetInstance("LogInfo").Info(@"开始批量数据入库");
                           dbHelper.AlarmStatusInsert(dataAdapter.DataResolve(new DataBaseHelper().AlarmStatusSelect()));
                           dbHelper.ControlStatusInsert(
                               dataAdapter.DataResolve(new DataBaseHelper().ControlStatusSelect()));
                           dbHelper.PowerDataInsert(dataAdapter.DataResolve(new DataBaseHelper().PowerDataSelect()));
                           dbHelper.SaveChanges();
                           CommonLogHelper.GetInstance("LogInfo").Info(@"批量数据入库成功");
                           new DataBaseHelper().DeleteAllSqLiteData();
                           CommonLogHelper.GetInstance("LogInfo").Info(@"本地数据删除成功");
                       }
                       catch (Exception ex)
                       {
                           CommonLogHelper.GetInstance("LogInfo").Info(@"批量数据入库失败");
                           CommonLogHelper.GetInstance("LogError").Error(@"批量数据入库失败", ex);
                       }
                       finally
                       {
                           dbHelper.Dispose();
                       }
                   }
               })
                { IsBackground = true };
                batchDataProcessThread.Start();

                #endregion 正常入库失败后批量数据补入
            }
        }

        private void tmrControl_Elapsed(object sender, EventArgs e)
        {
            _tmrControl.Stop();

            #region 台站级别发送指令

            try
            {
                Thread updateStatusThread = new Thread((ThreadStart)delegate
               {
                   if (Para.StationGrade.Contains("台站"))
                   {
                       byte[] cmd = SerialPortCmdCombine.SetBaseCommand("FF", "03");
                       CommonLogHelper.GetInstance("LogInfo")
                           .Info($@"延时8s后发送采集命令：{string.Join(" ", cmd.Select(x => x.ToString("X2")).ToArray())}");
                       _serialPort.SendCommand(cmd);
                   }
               })
                { IsBackground = true };
                updateStatusThread.Start();
            }
            catch (Exception ex)
            {
                CommonLogHelper.GetInstance("LogError").Error(@"发送串口命令获取数据过程出错", ex);
            }

            #endregion 台站级别发送指令
        }

        private void 电源阈值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AlarmSettingForm alarmSetForm = new AlarmSettingForm())
            {
                if (alarmSetForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _powerAlarmPara.GetXmlNodeInfo();
                    }
                    catch (Exception ex)
                    {
                        CommonLogHelper.GetInstance("LogError").Error(@"重新设置电源报警参数后读取出错", ex);
                    }
                }
            }
        }

        private void 模拟测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TabControlPanel tcp = new TabControlPanel { Dock = DockStyle.Fill };
            //TabItem tabItemNew = new TabItem { Name = "tbnew", Text = @"test", AttachedControl = tcp };
            //tcp.TabItem = tabItemNew;
            //tabControl.Controls.Add(tcp);
            //tabControl.Tabs.Add(tabItemNew);
            //tabControl.SelectedTab = tabItemNew;

            //DateTime dt = DateTime.Now;
            //string msg = string.Empty;
            //DataAdapter dataadp = new DataAdapter(StationId, dt);
            //dataadp.DataResolve(msg);

            //radarStatusUI.SetAlarmStatus(dataadp.AlarmStatusData);
            //radarControlUI.SetControlStatus(dataadp.ControlStatusData);
            //volCurIndicationUI.SetPowerDataValue(dataadp.RadarPowerData);
        }

        private void 启用控制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (启用控制ToolStripMenuItem.Text != @"禁用控制")
            {
                MessageBox.Show(@"开启控制后将停止后台采集数据，操作完毕后请及时禁用控制！", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AdminForm adminForm = new AdminForm();
                adminForm.EnableControl += () =>
                {
                    _tmr.Stop();
                    tSSLSystemStatus.Text = @"正在使用控制功能";
                    toolSslNextUpdateTime.Text = @"停止后台采集数据功能";
                    radarControlUI.Enabled = true;
                    启用控制ToolStripMenuItem.Text = @"禁用控制";
                    CommonLogHelper.GetInstance("LogInfo").Info(@"启用了控制功能");
                };
                adminForm.ShowDialog();
            }
            else
            {
                radarControlUI.Enabled = false;
                启用控制ToolStripMenuItem.Text = @"启用控制";
                tSSLSystemStatus.Text = @"等待采集数据";
                DateTime dt = DateTime.Now;
                DateTime obdt = dt.AddSeconds(-dt.Second).AddMilliseconds(-dt.Millisecond);
                toolSslNextUpdateTime.Text =
                    $"下次采集时间：{obdt.AddSeconds(30).AddMinutes(Para.UpdateDataIntl).ToString("yyyy-MM-dd HH:mm:ss")}";
                _tmr.Start();
            }
        }

        private void 实时采集ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DateTime obdt = dt.AddSeconds(-dt.Second).AddMilliseconds(-dt.Millisecond);

            #region 台站级别发送指令

            if (Para.StationGrade.Contains("台站"))
            {
                Thread collectThread = new Thread((ThreadStart)delegate
               {
                   try
                   {
                       SerialPortOperate tempSerialPortOperate = _serialPort;
                       //_tempSerialPortOperate.ReturnCollectorRecData += ManualRecDataProcessing;
                       byte[] cmd = SerialPortCmdCombine.SetBaseCommand("FF", "03");
                       CommonLogHelper.GetInstance("LogInfo")
                               .Info($@"实时采集：发送采集命令：{string.Join(" ", cmd.Select(x => x.ToString("X2")).ToArray())}");
                       tempSerialPortOperate.SendCommand(cmd);
                   }
                   catch (Exception ex)
                   {
                       CommonLogHelper.GetInstance("LogInfo").Info(@"实时采集：发送串口命令获取数据过程出错");
                       CommonLogHelper.GetInstance("LogError").Error(@"实时采集：发送串口命令获取数据过程出错", ex);
                       _synchContext.Post(a =>
                           MessageBox.Show(this, @"实时采集：发送串口命令获取数据过程出错，" + ex.Message, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                       , null);
                   }
               })
                { IsBackground = true };
                collectThread.Start();
            }

            #endregion 台站级别发送指令

            #region 省级级别操作数据库

            try
            {
                if (Para.StationGrade.Contains("省级"))
                {
                    Thread collectProThread = new Thread((ThreadStart)delegate
                   {
                       tSSLSystemStatus.Text = @"获取最新数据";
                       RadarDataClassesDataContext radarDataContext = new RadarDataClassesDataContext(_conn);
                       DataAdapter dataadp = new DataAdapter(StationId, obdt);
                       dataadp.DataResolve(radarDataContext);
                       _synchContext.Post(a =>
                       {
                           try
                           {
                               if (dataadp.AlarmStatusData != null)
                               {
                                   radarStatusUI.SetAlarmStatus(dataadp.AlarmStatusData);
                               }
                               if (dataadp.ControlStatusData != null)
                               {
                                   radarControlUI.SetControlStatus(dataadp.ControlStatusData);
                               }
                               if (dataadp.RadarPowerData != null)
                               {
                                   powerIndicationUI.SetPowerDataValue(dataadp.RadarPowerData);
                               }
                               if (dataadp.AlarmStatusData != null || dataadp.ControlStatusData != null ||
                                   dataadp.RadarPowerData != null)
                               {
                                   tSSLDataUpdateTime.Text = $"数据更新时间：{obdt.ToString("yyyy-MM-dd HH:mm")}";
                               }
                               else
                               {
                                   MessageBox.Show(@"无当前实时数据");
                               }
                           }
                           catch (Exception ex)
                           {
                               MessageBox.Show(@"数据显示到界面上出错" + ex);
                           }
                       }, null);
                       CommonLogHelper.GetInstance("LogInfo").Info(@"获取数据库数据成功");

                       try
                       {
                           RadarFailureAlarm(dataadp.AlarmStatusData);
                       }
                       catch (Exception ex)
                       {
                           CommonLogHelper.GetInstance("LogError").Error(@"雷达故障报警过程出错", ex);
                       }
                   })
                    { IsBackground = true };
                    collectProThread.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, @"提取数据库数据处理过程出错" + ex, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion 省级级别操作数据库
        }

        private void 数据查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataLineFormPro dataLineForm = new DataLineFormPro(Para);
            dataLineForm.Show();
        }

        private void 报警声音ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!报警声音ToolStripMenuItem.Checked)
            {
                _soundAlarm.StopAlarm();
            }
        }
    }
}