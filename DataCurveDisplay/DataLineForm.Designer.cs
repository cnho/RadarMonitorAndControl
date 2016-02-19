namespace DataCurveDisplay
{
    partial class DataLineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnSavePic = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.circularProgress = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.chartVolCur = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.saveFileDia = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVolCur)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gbControl);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 55);
            this.panel1.TabIndex = 0;
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnSavePic);
            this.gbControl.Controls.Add(this.btnExport);
            this.gbControl.Controls.Add(this.btnTest);
            this.gbControl.Controls.Add(this.label1);
            this.gbControl.Controls.Add(this.btnQuery);
            this.gbControl.Controls.Add(this.dtpEndTime);
            this.gbControl.Controls.Add(this.dtpStartTime);
            this.gbControl.Controls.Add(this.label2);
            this.gbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbControl.Location = new System.Drawing.Point(0, 0);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(933, 55);
            this.gbControl.TabIndex = 6;
            this.gbControl.TabStop = false;
            // 
            // btnSavePic
            // 
            this.btnSavePic.BackColor = System.Drawing.SystemColors.Control;
            this.btnSavePic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSavePic.Location = new System.Drawing.Point(715, 20);
            this.btnSavePic.Name = "btnSavePic";
            this.btnSavePic.Size = new System.Drawing.Size(75, 23);
            this.btnSavePic.TabIndex = 9;
            this.btnSavePic.Text = "保存图片";
            this.btnSavePic.UseVisualStyleBackColor = false;
            this.btnSavePic.Click += new System.EventHandler(this.btnSavePic_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.Control;
            this.btnExport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExport.Location = new System.Drawing.Point(634, 20);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "导出Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.SystemColors.Control;
            this.btnTest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTest.Location = new System.Drawing.Point(846, 20);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(143, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "开始时间：";
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuery.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuery.Location = new System.Drawing.Point(553, 20);
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
            this.dtpEndTime.Location = new System.Drawing.Point(421, 21);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(124, 21);
            this.dtpEndTime.TabIndex = 5;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(216, 21);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(124, 21);
            this.dtpStartTime.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(348, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "结束时间：";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.circularProgress);
            this.panel2.Controls.Add(this.chartVolCur);
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 505);
            this.panel2.TabIndex = 1;
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
            this.circularProgress.ProgressText = "正在加载，请稍等...";
            this.circularProgress.Size = new System.Drawing.Size(933, 505);
            this.circularProgress.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress.TabIndex = 2;
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
            this.chartVolCur.Size = new System.Drawing.Size(933, 505);
            this.chartVolCur.TabIndex = 2;
            // 
            // saveFileDia
            // 
            this.saveFileDia.Filter = "Jpeg图片|*.jpg|Png图片|*.png|Bmp图片|*.bmp|Tiff图片|*.tiff|Gif图片|*.gif|Emf图片|*.emf";
            this.saveFileDia.Title = "选择图片的保存位置";
            // 
            // DataLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "DataLineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "曲线图";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DataLineForm_Load);
            this.panel1.ResumeLayout(false);
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartVolCur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVolCur;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSavePic;
        private System.Windows.Forms.SaveFileDialog saveFileDia;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress;
    }
}