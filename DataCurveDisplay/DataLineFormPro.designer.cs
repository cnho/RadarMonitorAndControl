namespace DataCurveDisplay
{
    partial class DataLineFormPro
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.expandablePanel2 = new DevComponents.DotNetBar.ExpandablePanel();
            this.powerchkListBox = new System.Windows.Forms.CheckedListBox();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.stationchkListBox = new System.Windows.Forms.CheckedListBox();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.panel2 = new System.Windows.Forms.Panel();
            this.circularProgress = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.chartVolCur = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnSavePic = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.saveFileDia = new System.Windows.Forms.SaveFileDialog();
            this.panelEx1.SuspendLayout();
            this.expandablePanel2.SuspendLayout();
            this.expandablePanel1.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVolCur)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.Controls.Add(this.expandablePanel2);
            this.panelEx1.Controls.Add(this.expandablePanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(119, 577);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.StyleMouseDown.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.panelEx1.StyleMouseDown.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.panelEx1.StyleMouseDown.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder;
            this.panelEx1.StyleMouseDown.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText;
            this.panelEx1.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.panelEx1.StyleMouseOver.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.panelEx1.StyleMouseOver.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder;
            this.panelEx1.StyleMouseOver.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;
            this.panelEx1.TabIndex = 1;
            // 
            // expandablePanel2
            // 
            this.expandablePanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel2.Controls.Add(this.powerchkListBox);
            this.expandablePanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel2.HideControlsWhenCollapsed = true;
            this.expandablePanel2.Location = new System.Drawing.Point(0, 224);
            this.expandablePanel2.Name = "expandablePanel2";
            this.expandablePanel2.Size = new System.Drawing.Size(119, 351);
            this.expandablePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel2.Style.GradientAngle = 90;
            this.expandablePanel2.TabIndex = 1;
            this.expandablePanel2.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel2.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel2.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel2.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel2.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel2.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel2.TitleStyle.GradientAngle = 90;
            this.expandablePanel2.TitleText = "电源数据列表";
            // 
            // powerchkListBox
            // 
            this.powerchkListBox.CheckOnClick = true;
            this.powerchkListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.powerchkListBox.FormattingEnabled = true;
            this.powerchkListBox.Items.AddRange(new object[] {
            "全选",
            "+5V电压",
            "+15V电压",
            "-15V电压",
            "+28V电压",
            "+45V电压",
            "+510V电压",
            "灯丝逆变电压",
            "灯丝电压",
            "磁场电压",
            "钛泵电压",
            "电子注电压",
            "人工线充电电压",
            "阴极电流",
            "反峰电流",
            "灯丝电流",
            "聚焦线圈电流",
            "钛泵电流",
            "校平电流",
            "人工线充电电流"});
            this.powerchkListBox.Location = new System.Drawing.Point(0, 26);
            this.powerchkListBox.Name = "powerchkListBox";
            this.powerchkListBox.Size = new System.Drawing.Size(119, 325);
            this.powerchkListBox.TabIndex = 1;
            this.powerchkListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.powerchkListBox_ItemCheck);
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.stationchkListBox);
            this.expandablePanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel1.HideControlsWhenCollapsed = true;
            this.expandablePanel1.Location = new System.Drawing.Point(0, 0);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(119, 223);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 0;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "台站列表";
            // 
            // stationchkListBox
            // 
            this.stationchkListBox.CheckOnClick = true;
            this.stationchkListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stationchkListBox.FormattingEnabled = true;
            this.stationchkListBox.Location = new System.Drawing.Point(0, 26);
            this.stationchkListBox.Name = "stationchkListBox";
            this.stationchkListBox.Size = new System.Drawing.Size(119, 197);
            this.stationchkListBox.TabIndex = 1;
            this.stationchkListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.stationchkListBox_ItemCheck);
            // 
            // panelEx3
            // 
            this.panelEx3.Controls.Add(this.panel2);
            this.panelEx3.Controls.Add(this.panel1);
            this.panelEx3.Controls.Add(this.expandableSplitter1);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx3.Location = new System.Drawing.Point(119, 0);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(815, 577);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.StyleMouseDown.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.panelEx3.StyleMouseDown.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.panelEx3.StyleMouseDown.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder;
            this.panelEx3.StyleMouseDown.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText;
            this.panelEx3.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.StyleMouseOver.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground;
            this.panelEx3.StyleMouseOver.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground2;
            this.panelEx3.StyleMouseOver.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder;
            this.panelEx3.StyleMouseOver.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;
            this.panelEx3.TabIndex = 3;
            this.panelEx3.Text = "Fill Panel";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.circularProgress);
            this.panel2.Controls.Add(this.chartVolCur);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 522);
            this.panel2.TabIndex = 4;
            // 
            // circularProgress
            // 
            // 
            // 
            // 
            this.circularProgress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circularProgress.Location = new System.Drawing.Point(0, 0);
            this.circularProgress.Name = "circularProgress";
            this.circularProgress.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.circularProgress.Size = new System.Drawing.Size(805, 522);
            this.circularProgress.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress.TabIndex = 3;
            // 
            // chartVolCur
            // 
            this.chartVolCur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
            this.chartVolCur.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chartVolCur.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(64)))), ((int)(((byte)(1)))));
            this.chartVolCur.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartVolCur.BorderlineWidth = 2;
            this.chartVolCur.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea2.Area3DStyle.Inclination = 40;
            chartArea2.Area3DStyle.IsClustered = true;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea2.Area3DStyle.Perspective = 9;
            chartArea2.Area3DStyle.Rotation = 25;
            chartArea2.Area3DStyle.WallWidth = 3;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BackColor = System.Drawing.Color.OldLace;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "Default";
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            this.chartVolCur.ChartAreas.Add(chartArea2);
            this.chartVolCur.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Enabled = false;
            legend2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Default";
            this.chartVolCur.Legends.Add(legend2);
            this.chartVolCur.Location = new System.Drawing.Point(0, 0);
            this.chartVolCur.Name = "chartVolCur";
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.BorderWidth = 3;
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series3.Legend = "Default";
            series3.MarkerSize = 8;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Series1";
            series3.ShadowColor = System.Drawing.Color.Black;
            series3.ShadowOffset = 2;
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series4.BorderWidth = 3;
            series4.ChartArea = "Default";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series4.Legend = "Default";
            series4.MarkerSize = 9;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series4.Name = "Series2";
            series4.ShadowColor = System.Drawing.Color.Black;
            series4.ShadowOffset = 2;
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartVolCur.Series.Add(series3);
            this.chartVolCur.Series.Add(series4);
            this.chartVolCur.Size = new System.Drawing.Size(805, 522);
            this.chartVolCur.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 55);
            this.panel1.TabIndex = 3;
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnSavePic);
            this.gbControl.Controls.Add(this.btnExport);
            this.gbControl.Controls.Add(this.label1);
            this.gbControl.Controls.Add(this.btnQuery);
            this.gbControl.Controls.Add(this.dtpEndTime);
            this.gbControl.Controls.Add(this.dtpStartTime);
            this.gbControl.Controls.Add(this.label2);
            this.gbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbControl.Location = new System.Drawing.Point(0, 0);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(805, 55);
            this.gbControl.TabIndex = 6;
            this.gbControl.TabStop = false;
            // 
            // btnSavePic
            // 
            this.btnSavePic.BackColor = System.Drawing.SystemColors.Control;
            this.btnSavePic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSavePic.Location = new System.Drawing.Point(651, 20);
            this.btnSavePic.Name = "btnSavePic";
            this.btnSavePic.Size = new System.Drawing.Size(75, 23);
            this.btnSavePic.TabIndex = 8;
            this.btnSavePic.Text = "保存图片";
            this.btnSavePic.UseVisualStyleBackColor = false;
            this.btnSavePic.Click += new System.EventHandler(this.btnSavePic_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.Control;
            this.btnExport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExport.Location = new System.Drawing.Point(570, 20);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "导出Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(79, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "开始时间：";
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuery.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuery.Location = new System.Drawing.Point(489, 20);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(357, 21);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(124, 21);
            this.dtpEndTime.TabIndex = 5;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(152, 21);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(124, 21);
            this.dtpStartTime.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(284, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "结束时间：";
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter1.ExpandableControl = this.panelEx1;
            this.expandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.ExpandLineColor = System.Drawing.SystemColors.ControlText;
            this.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripDarkColor = System.Drawing.SystemColors.ControlText;
            this.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(142)))), ((int)(((byte)(75)))));
            this.expandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(139)))));
            this.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotExpandLineColor = System.Drawing.SystemColors.ControlText;
            this.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.Location = new System.Drawing.Point(0, 0);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(10, 577);
            this.expandableSplitter1.TabIndex = 2;
            this.expandableSplitter1.TabStop = false;
            // 
            // saveFileDia
            // 
            this.saveFileDia.Filter = "Jpeg图片|*.jpg|Png图片|*.png|Bmp图片|*.bmp|Tiff图片|*.tiff|Gif图片|*.gif|Emf图片|*.emf";
            this.saveFileDia.Title = "选择保存图片的位置";
            // 
            // DataLineFormPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 577);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx1);
            this.Name = "DataLineFormPro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电源数据查询";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DataLineFormPro_Load);
            this.panelEx1.ResumeLayout(false);
            this.expandablePanel2.ResumeLayout(false);
            this.expandablePanel1.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartVolCur)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private System.Windows.Forms.CheckedListBox stationchkListBox;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel2;
        private System.Windows.Forms.CheckedListBox powerchkListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVolCur;
        private System.Windows.Forms.Button btnSavePic;
        private System.Windows.Forms.SaveFileDialog saveFileDia;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress;
    }
}

