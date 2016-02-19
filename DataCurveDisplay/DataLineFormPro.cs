using Common;
using DataBaseOperate;
using ExportData2Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DataCurveDisplay
{
    public partial class DataLineFormPro : Form
    {
        private readonly Dictionary<string, Dictionary<string, List<string>>> _powerDataDics = new Dictionary<string, Dictionary<string, List<string>>>();

        private readonly Dictionary<string, List<string>> _sheetNameList = new Dictionary<string, List<string>>();

        private readonly SynchronizationContext _synchContext;

        public DataLineFormPro(CommonPara para)
        {
            InitializeComponent();
            _synchContext = SynchronizationContext.Current;
            _para = para;
        }

        public List<string> DataNamesList { get; set; }
        private CommonPara _para;

        private void btnExport_Click(object sender, EventArgs e)
        {
            saveFileDia.Title = @"请选择文件的保存位置";
            saveFileDia.Filter = "Excel 97-2003 工作簿|*.xls";//Excel 工作簿|*.xlsx|
            saveFileDia.FileName = @"雷达电源数据";
            try
            {
                if (saveFileDia.ShowDialog() == DialogResult.OK)
                {
                    Export2Excel.ExportToExcel(_powerDataDics, _sheetNameList, saveFileDia.FileName);
                    MessageBox.Show($@"保存Excel文件{saveFileDia.FileName}成功！", @"提示", MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                CommonLogHelper.GetInstance("LogError").Error(@"数据查询窗口导出数据到Excel过程出错", exception);
                MessageBox.Show(@"保存Excel文件过程出错，" + exception.Message, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Thread drawDataLineProThread = new Thread((ThreadStart)delegate
           {
               try
               {
                   _synchContext.Post(a =>
                   {
                       gbControl.Enabled = false;
                       stationchkListBox.Enabled = false;
                       powerchkListBox.Enabled = false;
                       circularProgress.IsRunning = true;
                       circularProgress.Visible = true;
                   }, null);
                   _powerDataDics.Clear();
                   _sheetNameList.Clear();
                   List<string> stationsList = new List<string>();
                   for (int i = 1; i < stationchkListBox.Items.Count; i++)
                   {
                       if (stationchkListBox.GetItemChecked(i))
                       {
                           stationsList.Add(stationchkListBox.GetItemText(stationchkListBox.Items[i]));
                       }
                   }
                   string conn =
                       $"Data Source={_para.SqlServerPara.SqlIp};Initial Catalog={_para.SqlServerPara.SqlDb};User ID={_para.SqlServerPara.SqlUser};Password={_para.SqlServerPara.SqlPwd};";
                   DateTime sdt = dtpStartTime.Value;
                   DateTime edt = dtpEndTime.Value;
                   RadarDataClassesDataContext radarDataClasses = new RadarDataClassesDataContext(conn);
                   List<string> powerList = new List<string>();
                   for (int i = 1; i < powerchkListBox.Items.Count; i++)
                   {
                       if (powerchkListBox.GetItemChecked(i))
                       {
                           powerList.Add(powerchkListBox.GetItemText(powerchkListBox.Items[i]));
                       }
                   }

                   for (int i = 0; i < powerList.Count; i++)
                   {
                       powerList[i] = DataEnum2Titles.ToProperties(powerList[i]);
                   }

                   _synchContext.Post(a =>
                   {
                       chartVolCur.Titles.Clear();
                       chartVolCur.Titles.Add("电源数据曲线图");
                       chartVolCur.Titles.Add(
                           $"({sdt.ToString(CultureInfo.InvariantCulture)}——{edt.ToString(CultureInfo.InvariantCulture)})");
                       chartVolCur.ChartAreas.Clear();
                       chartVolCur.Series.Clear();
                       chartVolCur.Legends.Clear();
                       ChartArea ca = new ChartArea("Default");
                       chartVolCur.ChartAreas.Add(ca);
                       chartVolCur.ChartAreas[0].AxisX.IsMarginVisible = true;
                       chartVolCur.ChartAreas[0].AxisX.Interval = 1;
                       chartVolCur.ChartAreas[0].AxisX.MajorGrid.Interval = 1;

                       //chartVolCur.Legends["Legend2"].DockedToChartArea = "Default";

                       foreach (var stationid in stationsList)
                       {
                           Dictionary<string, List<string>> powerDataDic = new Dictionary<string, List<string>>();

                           List<string> columnName = new List<string>();

                           chartVolCur.Legends.Add(new Legend(stationid) { Title = stationid, Docking = Docking.Bottom });
                           foreach (var powerName in powerList)
                           {
                               //chartVolCur.Legends["Legend2"].CellColumns.Add(new LegendCellColumn("Name", LegendCellColumnType.Text, stationid));
                               // Assign the legend to Series1.

                               Series s = new Series(stationid + "_" + powerName)
                               {
                                   MarkerSize = 10,
                                   MarkerStyle = MarkerStyle.Star10,
                                   ChartType = SeriesChartType.Line,
                                   IsValueShownAsLabel = true,
                                   BorderWidth = 3,
                                   ShadowOffset = 1,
                                   Legend = stationid,
                                   LegendText = DataEnum2Titles.ToTitles(powerName),
                                   IsVisibleInLegend = true,
                                   Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold),
                               };
                               var allpowerdata = (from vol in radarDataClasses.PowerDataTable
                                                   where stationsList.Contains(vol.StationID)
                                                         && vol.DateTime >= sdt && vol.DateTime <= edt
                                                   orderby vol.DateTime ascending
                                                   select vol).ToList();
                               for (int i = 0; i <= (edt - sdt).TotalMinutes; i++)
                               {
                                   DateTime dt = sdt.AddMinutes(i);
                                   List<string> powerdata = new List<string>();
                                   if (!powerDataDic.ContainsKey(dt.ToString(CultureInfo.InvariantCulture)))
                                   {
                                       powerDataDic.Add(dt.ToString(CultureInfo.InvariantCulture), powerdata);
                                   }
                                   var pd = (from v in allpowerdata
                                             where v.DateTime == dt && v.StationID == stationid
                                             select v).Distinct().ToList();
                                   if (pd.Count > 0)
                                   {
                                       object obj = (typeof(PowerDataTable)).GetProperty(powerName).GetValue(pd[0], null);
                                       s.Points.AddXY(dt.ToString("HH:mm"), obj);
                                       powerDataDic[dt.ToString(CultureInfo.InvariantCulture)].Add(obj.ToString());
                                   }
                                   else
                                   {
                                       s.Points.AddXY(dt.ToString("HH:mm"), DBNull.Value);
                                       powerDataDic[dt.ToString(CultureInfo.InvariantCulture)].Add(string.Empty);
                                   }
                               }
                               chartVolCur.Series.Add(s);

                               columnName.Add(DataEnum2Titles.ToTitles(powerName));
                           }

                           _powerDataDics.Add(stationid, powerDataDic);
                           _sheetNameList.Add(stationid, columnName);
                       }
                   }, null);
               }
               catch (Exception exception)
               {
                   CommonLogHelper.GetInstance("LogError").Error(@"数据查询并绘制曲线过程出错", exception);
                   _synchContext.Post(a =>
                           MessageBox.Show(this, @"绘制复杂曲线过程错误，" + exception.Message, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                       , null);
               }
               finally
               {
                   _synchContext.Post(a =>
                   {
                       gbControl.Enabled = true;
                       stationchkListBox.Enabled = true;
                       powerchkListBox.Enabled = true;
                       circularProgress.IsRunning = false;
                       circularProgress.Visible = false;
                   }, null);
               }
           })
            { IsBackground = true };
            drawDataLineProThread.Start();
        }

        private void btnSavePic_Click(object sender, EventArgs e)
        {
            saveFileDia.Title = @"请选择图片的保存位置";
            saveFileDia.Filter = "Jpeg图片|*.jpg|Png图片|*.png|Bmp图片|*.bmp|Tiff图片|*.tiff|Gif图片|*.gif|Emf图片|*.emf";
            saveFileDia.FileName = $@"雷达曲线图{DateTime.Now.ToString("yyyyMMddHHmmss")}";
            try
            {
                if (saveFileDia.ShowDialog() == DialogResult.OK)
                {
                    chartVolCur.SaveImage(saveFileDia.FileName, (ChartImageFormat)(saveFileDia.FilterIndex - 1));
                    MessageBox.Show($@"保存图片文件{saveFileDia.FileName}成功！", @"提示", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                CommonLogHelper.GetInstance("LogError").Error(@"数据查询窗口保存图片过程出错", exception);
                MessageBox.Show(@"保存图片文件过程出错，" + exception.Message, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataLineFormPro_Load(object sender, EventArgs e)
        {
            if (_para.StationGrade.Contains("台站"))
            {
                _para.StationProList = new List<Common.StationPara>();
                string conn =
                    $"Data Source={_para.SqlServerPara.SqlIp};Initial Catalog={_para.SqlServerPara.SqlDb};User ID={_para.SqlServerPara.SqlUser};Password={_para.SqlServerPara.SqlPwd};";
                RadarDataClassesDataContext radarDataContext = new RadarDataClassesDataContext(conn);
                var stations = (from s in radarDataContext.StationParaTable
                                select s).Distinct().ToList();
                foreach (Common.StationPara station in stations.Select(s => new Common.StationPara
                {
                    StationId = s.StationID,
                    StationName = s.StationName,
                    Slong = s.Slong,
                    Slat = s.Slat
                }))
                {
                    _para.StationProList.Add(station);
                }
            }
            DateTime dt = DateTime.Now;
            DateTime dtvalue = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, 0);
            dtpEndTime.MaxDate = dtvalue;
            dtpEndTime.Value = dtvalue;
            dtpStartTime.MaxDate = dtvalue;
            dtpStartTime.Value = dtvalue.AddHours(-1);
            stationchkListBox.Items.Add("全选");
            string[] ss = (from d in _para.StationProList
                           select d.StationId).ToArray();
            stationchkListBox.Items.AddRange(ss);
        }

        private void powerchkListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0)
            {
                for (int i = 1; i < powerchkListBox.Items.Count; i++)
                {
                    powerchkListBox.SetItemChecked(i, !powerchkListBox.GetItemChecked(0));
                }
            }
        }

        private void stationchkListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0)
            {
                for (int i = 1; i < stationchkListBox.Items.Count; i++)
                {
                    stationchkListBox.SetItemChecked(i, !stationchkListBox.GetItemChecked(0));
                }
            }
        }
    }
}