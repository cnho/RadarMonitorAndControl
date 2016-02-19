using Common;
using DataBaseOperate;
using ExportData2Excel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DataCurveDisplay
{
    public partial class DataLineForm : Form
    {
        private readonly Dictionary<string, string> _powerData = new Dictionary<string, string>();
        private readonly SynchronizationContext _synchContext;

        public DataLineForm()
        {
            InitializeComponent();
            _synchContext = SynchronizationContext.Current;
        }

        public string ConnectionString { get; set; }
        public string DataName { get; set; }
        public string StationId { get; set; }

        private void btnExport_Click(object sender, EventArgs e)
        {
            saveFileDia.Title = @"请选择文件的保存位置";
            saveFileDia.Filter = "Excel 97-2003 工作簿|*.xls";//Excel 工作簿|*.xlsx|
            try
            {
                string sheetName = StationId;
                string columnName = DataEnum2Titles.ToTitles(DataName);
                saveFileDia.FileName = $@"{StationId}雷达{columnName}电源数据";
                if (saveFileDia.ShowDialog() == DialogResult.OK)
                {
                    Export2Excel.ExportToExcel(_powerData, columnName, sheetName, saveFileDia.FileName);
                    MessageBox.Show($@"保存Excel文件{saveFileDia.FileName}成功！", @"提示", MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                CommonLogHelper.GetInstance("LogError").Error(@"实时数据查询窗口导出数据Excel过程出错", exception);
                MessageBox.Show(@"保存Excel文件过程出错，" + exception.Message, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DrawNowDataLine();
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
                CommonLogHelper.GetInstance("LogError").Error(@"实时数据查询窗口保存图片过程出错", exception);
                MessageBox.Show(@"保存图片文件过程出错，" + exception.Message, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            ////////DateTime dt = DateTime.Now;
            ////////Random random = new Random();
            ////////chartVolCur.ChartAreas.Clear();
            ////////chartVolCur.Series.Clear();
            ////////ChartArea ca = new ChartArea("CA1");
            ////////chartVolCur.ChartAreas.Add(ca);
            ////////Series s = new Series("S1")
            ////////{
            ////////    ChartType = SeriesChartType.Line,
            ////////    IsValueShownAsLabel = true,
            ////////    BorderWidth = 3,
            ////////    ShadowOffset = 1
            ////////};
            ////////chartVolCur.ChartAreas[0].AxisX.IsMarginVisible = true;
            ////////chartVolCur.ChartAreas[0].AxisX.Interval = 1;
            ////////chartVolCur.ChartAreas[0].AxisX.MajorGrid.Interval = 1;
            ////////for (int pointIndex = 0; pointIndex < 60; pointIndex++)
            ////////{
            ////////    s.Points.AddXY(dt.AddMinutes(pointIndex).Minute.ToString(), random.Next(-100, 200).ToString());
            ////////}
            ////////chartVolCur.Series.Add(s);

            ////chartVolCur.ChartAreas[0].AxisX.MajorGrid.IntervalType = DateTimeIntervalType.Hours;
            //chartVolCur.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            //chartVolCur.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd HH:mm:ss";
            //////chartVolCur.ChartAreas[0].AxisX.Minimum = dt.ToOADate();
            //////chartVolCur.ChartAreas[0].AxisX.Crossing = chartVolCur.ChartAreas[0].AxisX.Minimum;
            //////chartVolCur.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Hours;

            //chartVolCur.ChartAreas[0].AxisX.MajorGrid.IntervalType = DateTimeIntervalType.Days;
            //chartVolCur.ChartAreas[0].AxisX.Minimum=dt;
            //chartVolCur.ChartAreas[0].AxisY.IsMarginVisible = false;
            //s.ChartArea = chartVolCur.ChartAreas[0].Name;
            //chartVolCur.ChartAreas[0].AxisX
            //chartVolCur.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;

            //Series series = new Series("Line");
            //series.ChartType = SeriesChartType.Line;
            //series.IsValueShownAsLabel = true;
            //series.BorderWidth = 3;
            //series.ShadowOffset = 1;
            //// Populate new series with data
            //series.Points.AddXY(dt,67);
            //series.Points.AddXY(dt.AddDays(1),50);
            //series.Points.AddXY(dt.AddDays(2), 83);
            //series.Points.AddXY(dt.AddDays(3), 23);
            //series.Points.AddXY(dt.AddDays(4), 70);
            //series.Points.AddXY(dt.AddDays(5), DBNull.Value);
            //series.Points.AddXY(dt.AddDays(6), 90);
            //series.Points.AddXY(dt.AddDays(7), 20);              // Add series into the chart's series collection
            //series.ChartArea = chartVolCur.ChartAreas[0].Name;

            //chartVolCur.Series.Add(series);
        }

        private void DataLineForm_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DateTime dtvalue = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, 0);
            dtpEndTime.MaxDate = dtvalue;
            dtpEndTime.Value = dtvalue;
            dtpStartTime.MaxDate = dtvalue;
            dtpStartTime.Value = dtvalue.AddMinutes(-30);
            DrawNowDataLine();
        }

        private void DrawNowDataLine()
        {
            Thread drawDataLineThread = new Thread((ThreadStart)delegate
            {
                try
                {
                    _synchContext.Post(a =>
                    {
                        gbControl.Enabled = false;
                        circularProgress.IsRunning = true;
                        circularProgress.Visible = true;
                    }, null);
                    _powerData.Clear();
                    DateTime sdt = dtpStartTime.Value;
                    DateTime edt = dtpEndTime.Value;
                    RadarDataClassesDataContext radarDataClasses = new RadarDataClassesDataContext(ConnectionString);
                    _synchContext.Post(a =>
                    {
                        chartVolCur.Titles.Clear();
                        chartVolCur.Titles.Add(DataEnum2Titles.ToTitles(DataName));
                        chartVolCur.Titles.Add(
                            $"({sdt.ToString(CultureInfo.InvariantCulture)}——{edt.ToString(CultureInfo.InvariantCulture)})");
                        chartVolCur.ChartAreas.Clear();
                        chartVolCur.Series.Clear();
                        ChartArea ca = new ChartArea("CA1");
                        chartVolCur.ChartAreas.Add(ca);
                        Series s = new Series("S1")
                        {
                            ChartType = SeriesChartType.Line,
                            IsValueShownAsLabel = true,
                            BorderWidth = 3,
                            ShadowOffset = 1
                        };
                        chartVolCur.ChartAreas[0].AxisX.IsMarginVisible = true;
                        chartVolCur.ChartAreas[0].AxisX.Interval = 1;
                        chartVolCur.ChartAreas[0].AxisX.MajorGrid.Interval = 1;
                        try
                        {
                            var powerdata = (from p in radarDataClasses.PowerDataTable
                                           where p.StationID == StationId
                                                 && p.DateTime >= sdt && p.DateTime <= edt
                                           orderby p.DateTime ascending
                                           select p).ToList();
                            for (int i = 0; i <= (edt - sdt).TotalMinutes; i++)
                            {
                                DateTime dt = sdt.AddMinutes(i);
                                var pd = (from v in powerdata
                                          where v.DateTime == dt
                                          select v).Distinct().ToList();
                                if (pd.Count > 0)
                                {
                                    object obj = typeof(PowerDataTable).GetProperty(DataName).GetValue(pd[0], null);
                                    s.Points.AddXY(dt.ToString("HH:mm"), obj);
                                    _powerData.Add(dt.ToString(CultureInfo.InvariantCulture), obj.ToString());
                                }
                                else
                                {
                                    s.Points.AddXY(dt.ToString("HH:mm"), DBNull.Value);
                                    _powerData.Add(dt.ToString(CultureInfo.InvariantCulture), string.Empty);
                                }
                            }
                            chartVolCur.Series.Add(s);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }, null);
                }
                catch (Exception exception)
                {
                    CommonLogHelper.GetInstance("LogError").Error(@"实时数据查询并绘制曲线过程出错", exception);
                    _synchContext.Post(a =>
                        MessageBox.Show(this, @"绘制当前曲线过程错误，" + exception.Message, @"错误", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
                        , null);
                }
                finally
                {
                    _synchContext.Post(a =>
                    {
                        gbControl.Enabled = true;
                        circularProgress.IsRunning = false;
                        circularProgress.Visible = false;
                    }, null);
                }
            })
            { IsBackground = true };
            drawDataLineThread.Start();
        }
    }
}