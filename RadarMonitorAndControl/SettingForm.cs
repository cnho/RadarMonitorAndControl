using Common;
using DataBaseOperate;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using StationPara = Common.StationPara;

namespace RadarMonitorAndControl
{
    public partial class SettingForm : Form
    {
        private CommonPara _para;

        public SettingForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvStationList.RowCount; i++)
            {
                if (dgvStationList[0, dgvStationList.CurrentCell.RowIndex].Value != null && dgvStationList[0, dgvStationList.CurrentCell.RowIndex].Value.ToString() != string.Empty)
                {
                    if (dgvStationList[1, dgvStationList.CurrentCell.RowIndex].Value == null || dgvStationList[1, dgvStationList.CurrentCell.RowIndex].Value.ToString() == string.Empty)
                    {
                        MessageBox.Show(@"站号必须输入", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            try
            {
                _para = new CommonPara
                {
                    StationGrade = cmbGrade.SelectedItem.ToString(),
                    UpdateDataIntl = (int)(nUdIntl.Value),
                    SerialPortPara =
                    {
                        PortName = cmbSerialPort.SelectedItem.ToString(),
                        BaudRate = int.Parse(cmbBaudRate.SelectedItem.ToString()),
                        DataBits = int.Parse(cmbDataBits.SelectedItem.ToString()),
                        StopBits = cmbStopBit.SelectedItem.ToString(),
                        CheckBit = cmbCheckBit.SelectedItem.ToString()
                    },
                    SqlServerPara =
                    {
                        SqlIp = tbSqlIp.Text,
                        SqlDb = tbDataBase.Text,
                        SqlUser = tbUser.Text,
                        SqlPwd = tbPassword.Text
                    },
                };

                if (_para.StationGrade.Contains("台站"))
                {
                    if (dgvStationList[1, 0].Value != null && dgvStationList[1, 0].Value.ToString() != string.Empty)
                    {
                        StationPara station = new StationPara
                        {
                            StationId = dgvStationList[1, 0].Value.ToString(),
                            StationName = dgvStationList[2, 0].Value.ToString(),
                            Slong = dgvStationList[3, 0].Value.ToString(),
                            Slat = dgvStationList[4, 0].Value.ToString()
                        };
                        _para.StationInfo = station;
                    }
                    else
                    {
                        MessageBox.Show(@"请配置台站信息", @"注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    try
                    {
                        string conn =
                            $"Data Source={_para.SqlServerPara.SqlIp};Initial Catalog={_para.SqlServerPara.SqlDb};User ID={_para.SqlServerPara.SqlUser};Password={_para.SqlServerPara.SqlPwd};";
                        DataBaseOperate.StationParaTable stationInfo = new DataBaseOperate.StationParaTable
                        {
                            ID = Guid.NewGuid(),
                            StationID = _para.StationInfo.StationId,
                            StationName = _para.StationInfo.StationName,
                            Slong = _para.StationInfo.Slong,
                            Slat = _para.StationInfo.Slat
                        };
                        DataBaseHelper dbHelper = new DataBaseHelper(conn);
                        dbHelper.StationParaInsertorUpdate(stationInfo);
                        dbHelper.SaveChanges();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(@"保存台站信息到远程数据库出错：" + Environment.NewLine + exception.Message, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Parameter.WriteCfg(_para);
                Close();
            }
            catch (Exception exception)
            {
                CommonLogHelper.GetInstance("LogError").Error(@"保存参数文件出错", exception);
                MessageBox.Show(@"保存参数文件出错", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                Array.Sort(ports);
                cmbSerialPort.Items.AddRange(ports);
            }
            catch (Exception exception)
            {
                CommonLogHelper.GetInstance("LogError").Error(@"加载本机串口号出错", exception);
                MessageBox.Show(@"加载本机串口号出错", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                _para = Parameter.ReadCfg();

                cmbSerialPort.SelectedItem = _para.SerialPortPara.PortName;
                cmbBaudRate.SelectedItem = _para.SerialPortPara.BaudRate.ToString(CultureInfo.InvariantCulture);
                cmbDataBits.SelectedItem = _para.SerialPortPara.DataBits.ToString(CultureInfo.InvariantCulture);
                cmbStopBit.SelectedItem = _para.SerialPortPara.StopBits.ToString(CultureInfo.InvariantCulture);
                cmbCheckBit.SelectedItem = _para.SerialPortPara.CheckBit;

                tbSqlIp.Text = _para.SqlServerPara.SqlIp;
                tbDataBase.Text = _para.SqlServerPara.SqlDb;
                tbUser.Text = _para.SqlServerPara.SqlUser;
                tbPassword.Text = _para.SqlServerPara.SqlPwd;

                nUdIntl.Value = _para.UpdateDataIntl;
                cmbGrade.SelectedItem = _para.StationGrade;
                //if (para.StationGrade.Contains("省级"))
                //{
                //    dgvStationList.ReadOnly = true;
                //    dgvStationList.RowCount = para.StationList.Count;
                //    for (int i = 0; i < dgvStationList.RowCount; i++)
                //    {
                //        dgvStationList[0, i].Value = (i + 1).ToString(CultureInfo.InvariantCulture);
                //        dgvStationList[1, i].Value = para.StationList[i].StationId;
                //        dgvStationList[2, i].Value = para.StationList[i].StationName;
                //        dgvStationList[3, i].Value = para.StationList[i].Slong;
                //        dgvStationList[4, i].Value = para.StationList[i].Slat;
                //    }
                //}
                //else
                //{
                //    dgvStationList.ReadOnly = false;
                //    dgvStationList.RowCount = 1;
                //    dgvStationList[0, 0].Value = "1";
                //    dgvStationList[1, 0].Value = para.StationList[0].StationId;
                //    dgvStationList[2, 0].Value = para.StationList[0].StationName;
                //    dgvStationList[3, 0].Value = para.StationList[0].Slong;
                //    dgvStationList[4, 0].Value = para.StationList[0].Slat;
                //}
            }
            catch (Exception exception)
            {
                CommonLogHelper.GetInstance("LogError").Error(@"读取参数文件出错", exception);
                MessageBox.Show(@"读取参数文件出错", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
            {
                return;
            }
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(((ComboBox)sender).Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.X, e.Bounds.Y + 3);
        }

        private void cmbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGrade.SelectedItem.ToString().Contains("省级"))
            {
                gbSerialPort.Enabled = false;
                dgvStationList.ReadOnly = true;
                string conn = $"Data Source={tbSqlIp.Text};Initial Catalog={tbDataBase.Text};User ID={tbUser.Text};Password={tbPassword.Text};";
                RadarDataClassesDataContext radarDataContext = new RadarDataClassesDataContext(conn);
                var stations = (from s in radarDataContext.StationParaTable
                                select s).Distinct().ToList();
                dgvStationList.RowCount = stations.Count;
                for (int i = 0; i < dgvStationList.RowCount; i++)
                {
                    dgvStationList[0, i].Value = (i + 1).ToString(CultureInfo.InvariantCulture);
                    dgvStationList[1, i].Value = stations[i].StationID;
                    dgvStationList[2, i].Value = stations[i].StationName;
                    dgvStationList[3, i].Value = stations[i].Slong;
                    dgvStationList[4, i].Value = stations[i].Slat;
                }
            }
            else
            {
                gbSerialPort.Enabled = true;
                dgvStationList.ReadOnly = false;
                dgvStationList.RowCount = 1;
                dgvStationList[0, 0].Value = "1";
                dgvStationList[1, 0].Value = _para.StationInfo.StationId;
                dgvStationList[2, 0].Value = _para.StationInfo.StationName;
                dgvStationList[3, 0].Value = _para.StationInfo.Slong;
                dgvStationList[4, 0].Value = _para.StationInfo.Slat;
            }
        }

        private void dgvStationList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool isnotempty = false;
            for (int i = 1; i < dgvStationList.ColumnCount; i++)
            {
                if (dgvStationList[i, dgvStationList.CurrentCell.RowIndex].Value != null && dgvStationList[i, dgvStationList.CurrentCell.RowIndex].Value.ToString() != string.Empty)
                {
                    isnotempty = true;
                }
            }
            if (!isnotempty)
            {
                dgvStationList[0, dgvStationList.CurrentCell.RowIndex].Value = null;
            }
        }

        private void btnSqlTest_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlconn =
                    $"Data Source={tbSqlIp.Text};Initial Catalog={tbDataBase.Text};Integrated Security=False;Connection Timeout=15;User ID={tbUser.Text};Password={tbPassword.Text}";
                using (SqlConnection connection = new SqlConnection(sqlconn))
                {
                    connection.Open();
                    connection.Close();
                }
                MessageBox.Show(@"数据库连接成功", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"数据库连接失败" + Environment.NewLine + ex.ToString(), @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}