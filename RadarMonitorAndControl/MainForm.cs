using Common;
using DataBaseOperate;
using SerialPortComm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FSLib.App.SimpleUpdater;
using StationPara = Common.StationPara;
using Tm = System.Timers;

namespace RadarMonitorAndControl
{
    public partial class MainForm : Form
    {
        private StatusMonitorControlForm _smcForm;

        private readonly SynchronizationContext _synchContext;
        
        private readonly Tm.Timer _tmr = new Tm.Timer();

        private CommonPara _para;

        public MainForm()
        {
            InitializeComponent();
            _tmr.Interval = 1000;
            _tmr.Elapsed += tmr_Elapsed;
            _synchContext = SynchronizationContext.Current;
        }

        private static void updater_OnUpdaterOnMinmumVersionRequired(object s, EventArgs e)
        {
            CommonLogHelper.GetInstance("LogError").Error("当前版本过低无法使用自动更新！");
            MessageBox.Show(@"当前版本过低无法使用自动更新！");
        }

        private static void updater_UpdatesFound(object sender, EventArgs e)
        {
            CommonLogHelper.GetInstance("LogInfo").Info($"发现了新版本：{Updater.Instance.Context.UpdateInfo.AppVersion}");

        }

        private static void updater_NoUpdatesFound(object sender, EventArgs e)
        {
            CommonLogHelper.GetInstance("LogInfo").Info("没有新版本！");
        }

        private static void updater_Error(object sender, EventArgs e)
        {
            CommonLogHelper.GetInstance("LogError").Error(@"更新发生了错误", Updater.Instance.Context.Exception);
            MessageBox.Show($"更新发生了错误：{Updater.Instance.Context.Exception.Message}");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                var updater = Updater.Instance;
                updater.Error += updater_Error;
                updater.UpdatesFound += updater_UpdatesFound;
                updater.NoUpdatesFound += updater_NoUpdatesFound;
                updater.MinmumVersionRequired += updater_OnUpdaterOnMinmumVersionRequired;
                updater.BeginCheckUpdateInProcess();
            }
            catch (Exception exception)
            {
                CommonLogHelper.GetInstance("LogError").Error(@"自动更新过程出错", exception);
            }
            try
            {
                _para = Parameter.ReadCfg();
            }
            catch (Exception exception)
            {
                CommonLogHelper.GetInstance("LogError").Error(@"读取系统参数过程出错", exception);
                MessageBox.Show(@"读取系统参数过程出错", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (_para.StationGrade.Contains("省级"))
            {
                //采集器设置ToolStripMenuItem.Visible = false;
                台站选择ToolStripMenuItem.Visible = true;

                try
                {
                    _para.StationProList = new List<StationPara>();
                    string conn =
                        $"Data Source={_para.SqlServerPara.SqlIp};Initial Catalog={_para.SqlServerPara.SqlDb};User ID={_para.SqlServerPara.SqlUser};Password={_para.SqlServerPara.SqlPwd};";
                    RadarDataClassesDataContext radarDataContext = new RadarDataClassesDataContext(conn);
                    var stations = (from s in radarDataContext.StationParaTable
                                    select s).Distinct().ToList();
                    foreach (StationPara station in stations.Select(s => new StationPara
                    {
                        StationId = s.StationID,
                        StationName = s.StationName,
                        Slong = s.Slong,
                        Slat = s.Slat
                    }))
                    {
                        _para.StationProList.Add(station);
                    }
                    foreach (ToolStripMenuItem stationToolStripMenuItem in stations.Select(station => new ToolStripMenuItem
                    {
                        Name = "stationToolStripMenuItem",
                        Text = station.StationName,
                        Tag = station.StationID
                    }))
                    {
                        stationToolStripMenuItem.Click += StationToolStripMenuItem_Click;
                        台站选择ToolStripMenuItem.DropDownItems.Add(stationToolStripMenuItem);
                        StationToolStripMenuItem_Click(stationToolStripMenuItem, e);
                    }
                }
                catch (Exception exception)
                {
                    CommonLogHelper.GetInstance("LogError").Error(@"加载站点信息出错", exception);
                    MessageBox.Show(@"加载站点信息出错", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //采集器设置ToolStripMenuItem.Visible = true;
                台站选择ToolStripMenuItem.Visible = false;
                _smcForm = new StatusMonitorControlForm
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized,
                    Para = _para,
                    StationId = _para.StationInfo.StationId,
                };
                _smcForm.Show();
            }
            _tmr.Start();
        }

        private void StationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool mdiisopen = false;
            ToolStripMenuItem tsm = (ToolStripMenuItem)sender;
            foreach (Form mdiChild in MdiChildren.Where(mdiChild => mdiChild.Text.Contains(tsm.Tag.ToString())))
            {
                mdiisopen = true;
                mdiChild.Activate();
            }
            if (mdiisopen)
            {
                return;
            }
            StatusMonitorControlForm smcProForm = new StatusMonitorControlForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Normal,
                Para = _para,
                StationId = tsm.Tag.ToString()
            };
            smcProForm.Show();
        }

        private void tmr_Elapsed(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            if (dt.Hour == 0 && dt.Minute == 0 && dt.Second == 0)
            {
                var updater = Updater.Instance;
                updater.Error -= updater_Error;
                updater.UpdatesFound -= updater_UpdatesFound;
                updater.NoUpdatesFound -= updater_NoUpdatesFound;
                updater.MinmumVersionRequired -= updater_OnUpdaterOnMinmumVersionRequired;

                updater.Error += (s, ee) =>
                {
                    CommonLogHelper.GetInstance("LogError").Error(@"后台自动更新发生了错误", updater.Context.Exception);
                };
                updater.UpdatesFound += (s, ee) =>
                {
                    CommonLogHelper.GetInstance("LogInfo").Info($"后台自动更新发现了新版本：{updater.Context.UpdateInfo.AppVersion}");
                };
                updater.NoUpdatesFound += (s, ee) =>
                {
                    CommonLogHelper.GetInstance("LogInfo").Info("后台自动更新没有发现新版本！");
                };
                updater.MinmumVersionRequired += (s, ee) =>
                {
                    CommonLogHelper.GetInstance("LogWarn").Error("后台自动更新发现当前版本过低无法使用自动更新！");
                };
                updater.Context.ForceUpdate = true;
                updater.Context.MustUpdate = true;
                updater.Context.AutoClosePreviousPopup = true;
                updater.BeginCheckUpdateInProcess();
            }
            if (!IsDisposed)
            {
                _synchContext.Post(a =>
                {
                    TimeToolStripMenuItem.Text = dt.ToString("yyyy-MM-dd HH:mm:ss");
                }, null);
            }
        }

        private void 层叠排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void 垂直平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void 水平平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string staitongrad = _para.StationGrade;
            using (SettingForm setForm = new SettingForm())
            {
                var result = setForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _para = Parameter.ReadCfg();
                    if (!_para.StationGrade.Equals(staitongrad))
                    {
                        foreach (Form mdiChild in MdiChildren)
                        {
                            ((StatusMonitorControlForm)mdiChild).CanClose = true;
                            mdiChild.Close();
                        }
                        if (_para.StationGrade.Contains("省级"))
                        {
                            //采集器设置ToolStripMenuItem.Visible = false;
                            台站选择ToolStripMenuItem.Visible = true;
                            台站选择ToolStripMenuItem.DropDownItems.Clear();

                            try
                            {
                                _para.StationProList = new List<StationPara>();
                                string conn =
                                    $"Data Source={_para.SqlServerPara.SqlIp};Initial Catalog={_para.SqlServerPara.SqlDb};User ID={_para.SqlServerPara.SqlUser};Password={_para.SqlServerPara.SqlPwd};";
                                RadarDataClassesDataContext radarDataContext = new RadarDataClassesDataContext(conn);
                                var stations = (from s in radarDataContext.StationParaTable
                                                select s).Distinct().ToList();
                                foreach (StationPara station in stations.Select(s => new StationPara
                                {
                                    StationId = s.StationID,
                                    StationName = s.StationName,
                                    Slong = s.Slong,
                                    Slat = s.Slat
                                }))
                                {
                                    _para.StationProList.Add(station);
                                }
                                foreach (ToolStripMenuItem stationToolStripMenuItem in stations.Select(station => new ToolStripMenuItem
                                {
                                    Name = "stationToolStripMenuItem",
                                    Text = station.StationName,
                                    Tag = station.StationID
                                }))
                                {
                                    stationToolStripMenuItem.Click += StationToolStripMenuItem_Click;
                                    台站选择ToolStripMenuItem.DropDownItems.Add(stationToolStripMenuItem);
                                    StationToolStripMenuItem_Click(stationToolStripMenuItem, e);
                                }
                            }
                            catch (Exception exception)
                            {
                                CommonLogHelper.GetInstance("LogError").Error(@"加载站点信息出错", exception);
                                MessageBox.Show(@"加载站点信息出错", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            //采集器设置ToolStripMenuItem.Visible = true;
                            台站选择ToolStripMenuItem.Visible = false;
                            _smcForm = new StatusMonitorControlForm
                            {
                                MdiParent = this,
                                WindowState = FormWindowState.Maximized,
                                Para = _para,
                                StationId = _para.StationInfo.StationId
                            };
                            _smcForm.Show();
                        }
                    }
                }
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutRadarMonitor aboutRadarMonitor = new AboutRadarMonitor();
            aboutRadarMonitor.ShowDialog();
        }
    }
}