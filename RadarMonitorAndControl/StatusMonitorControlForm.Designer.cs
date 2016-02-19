using CustomControls;

namespace RadarMonitorAndControl
{
    partial class StatusMonitorControlForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusMonitorControlForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.powerIndicationUI = new CustomControls.PowerIndicationUi();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radarControlUI = new CustomControls.RadarControlUi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radarStatusUI = new CustomControls.RadarStatusUi();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.实时采集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启用控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报警设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.电源阈值ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报警声音ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.模拟测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tSSLSystemStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslNextUpdateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLDataUpdateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItemStatusMonitor = new DevComponents.DotNetBar.TabItem(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 566);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.powerIndicationUI);
            this.panel4.Location = new System.Drawing.Point(464, 244);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(515, 312);
            this.panel4.TabIndex = 2;
            // 
            // powerIndicationUI
            // 
            this.powerIndicationUI.Location = new System.Drawing.Point(7, 9);
            this.powerIndicationUI.MaximumSize = new System.Drawing.Size(500, 298);
            this.powerIndicationUI.MinimumSize = new System.Drawing.Size(500, 298);
            this.powerIndicationUI.Name = "powerIndicationUI";
            this.powerIndicationUI.Size = new System.Drawing.Size(500, 298);
            this.powerIndicationUI.SqlConnection = null;
            this.powerIndicationUI.StationId = null;
            this.powerIndicationUI.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.radarControlUI);
            this.panel3.Location = new System.Drawing.Point(464, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(515, 235);
            this.panel3.TabIndex = 1;
            // 
            // radarControlUI
            // 
            this.radarControlUI.Enabled = false;
            this.radarControlUI.Location = new System.Drawing.Point(7, 9);
            this.radarControlUI.MaximumSize = new System.Drawing.Size(500, 217);
            this.radarControlUI.MinimumSize = new System.Drawing.Size(500, 217);
            this.radarControlUI.Name = "radarControlUI";
            this.radarControlUI.Size = new System.Drawing.Size(500, 217);
            this.radarControlUI.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radarStatusUI);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 553);
            this.panel2.TabIndex = 0;
            // 
            // radarStatusUI
            // 
            this.radarStatusUI.Location = new System.Drawing.Point(10, 9);
            this.radarStatusUI.Name = "radarStatusUI";
            this.radarStatusUI.Size = new System.Drawing.Size(434, 535);
            this.radarStatusUI.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.实时采集ToolStripMenuItem,
            this.启用控制ToolStripMenuItem,
            this.报警设置ToolStripMenuItem,
            this.数据查询ToolStripMenuItem,
            this.模拟测试ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(992, 25);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 实时采集ToolStripMenuItem
            // 
            this.实时采集ToolStripMenuItem.Name = "实时采集ToolStripMenuItem";
            this.实时采集ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.实时采集ToolStripMenuItem.Text = "实时采集";
            this.实时采集ToolStripMenuItem.Click += new System.EventHandler(this.实时采集ToolStripMenuItem_Click);
            // 
            // 启用控制ToolStripMenuItem
            // 
            this.启用控制ToolStripMenuItem.Name = "启用控制ToolStripMenuItem";
            this.启用控制ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.启用控制ToolStripMenuItem.Text = "启用控制";
            this.启用控制ToolStripMenuItem.Visible = false;
            this.启用控制ToolStripMenuItem.Click += new System.EventHandler(this.启用控制ToolStripMenuItem_Click);
            // 
            // 报警设置ToolStripMenuItem
            // 
            this.报警设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.电源阈值ToolStripMenuItem,
            this.报警声音ToolStripMenuItem});
            this.报警设置ToolStripMenuItem.Name = "报警设置ToolStripMenuItem";
            this.报警设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.报警设置ToolStripMenuItem.Text = "报警设置";
            // 
            // 电源阈值ToolStripMenuItem
            // 
            this.电源阈值ToolStripMenuItem.Name = "电源阈值ToolStripMenuItem";
            this.电源阈值ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.电源阈值ToolStripMenuItem.Text = "电源阈值";
            this.电源阈值ToolStripMenuItem.Click += new System.EventHandler(this.电源阈值ToolStripMenuItem_Click);
            // 
            // 报警声音ToolStripMenuItem
            // 
            this.报警声音ToolStripMenuItem.Checked = true;
            this.报警声音ToolStripMenuItem.CheckOnClick = true;
            this.报警声音ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.报警声音ToolStripMenuItem.Name = "报警声音ToolStripMenuItem";
            this.报警声音ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.报警声音ToolStripMenuItem.Text = "报警声音";
            this.报警声音ToolStripMenuItem.Click += new System.EventHandler(this.报警声音ToolStripMenuItem_Click);
            // 
            // 数据查询ToolStripMenuItem
            // 
            this.数据查询ToolStripMenuItem.Name = "数据查询ToolStripMenuItem";
            this.数据查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.数据查询ToolStripMenuItem.Text = "数据查询";
            this.数据查询ToolStripMenuItem.Click += new System.EventHandler(this.数据查询ToolStripMenuItem_Click);
            // 
            // 模拟测试ToolStripMenuItem
            // 
            this.模拟测试ToolStripMenuItem.Name = "模拟测试ToolStripMenuItem";
            this.模拟测试ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.模拟测试ToolStripMenuItem.Text = "模拟测试";
            this.模拟测试ToolStripMenuItem.Visible = false;
            this.模拟测试ToolStripMenuItem.Click += new System.EventHandler(this.模拟测试ToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSLSystemStatus,
            this.tSSLMessage,
            this.toolSslNextUpdateTime,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel1,
            this.tSSLDataUpdateTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 618);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(992, 26);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tSSLSystemStatus
            // 
            this.tSSLSystemStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tSSLSystemStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tSSLSystemStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSSLSystemStatus.Name = "tSSLSystemStatus";
            this.tSSLSystemStatus.Size = new System.Drawing.Size(84, 21);
            this.tSSLSystemStatus.Text = "等待采集数据";
            // 
            // tSSLMessage
            // 
            this.tSSLMessage.Name = "tSSLMessage";
            this.tSSLMessage.Size = new System.Drawing.Size(0, 21);
            // 
            // toolSslNextUpdateTime
            // 
            this.toolSslNextUpdateTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolSslNextUpdateTime.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolSslNextUpdateTime.Name = "toolSslNextUpdateTime";
            this.toolSslNextUpdateTime.Size = new System.Drawing.Size(96, 21);
            this.toolSslNextUpdateTime.Text = "下次采集时间：";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(681, 21);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabel1.Image = global::RadarMonitorAndControl.Properties.Resources.green_light;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(20, 21);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tSSLDataUpdateTime
            // 
            this.tSSLDataUpdateTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tSSLDataUpdateTime.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tSSLDataUpdateTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSSLDataUpdateTime.Name = "tSSLDataUpdateTime";
            this.tSSLDataUpdateTime.Size = new System.Drawing.Size(96, 21);
            this.tSSLDataUpdateTime.Text = "数据更新时间：";
            // 
            // tabControl
            // 
            this.tabControl.AutoCloseTabs = true;
            this.tabControl.CanReorderTabs = true;
            this.tabControl.Controls.Add(this.tabControlPanel1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 25);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.tabControl.SelectedTabIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(992, 593);
            this.tabControl.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabControl.TabIndex = 3;
            this.tabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl.Tabs.Add(this.tabItemStatusMonitor);
            this.tabControl.Text = "tabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.panel1);
            this.tabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(992, 568);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItemStatusMonitor;
            // 
            // tabItemStatusMonitor
            // 
            this.tabItemStatusMonitor.AttachedControl = this.tabControlPanel1;
            this.tabItemStatusMonitor.Name = "tabItemStatusMonitor";
            this.tabItemStatusMonitor.Text = "状态监控和控制";
            // 
            // StatusMonitorControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 644);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "StatusMonitorControlForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "雷达状态监控和控制";
            this.Load += new System.EventHandler(this.StatusMonitorControlForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StatusMonitorControlForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private RadarStatusUi radarStatusUI;
        private System.Windows.Forms.Panel panel4;
        private PowerIndicationUi powerIndicationUI;
        private RadarControlUi radarControlUI;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 实时采集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启用控制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 模拟测试ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tSSLSystemStatus;
        private System.Windows.Forms.ToolStripStatusLabel tSSLMessage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tSSLDataUpdateTime;
        private System.Windows.Forms.ToolStripMenuItem 数据查询ToolStripMenuItem;
        private DevComponents.DotNetBar.TabControl tabControl;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItemStatusMonitor;
        private System.Windows.Forms.ToolStripMenuItem 报警设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem 电源阈值ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报警声音ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolSslNextUpdateTime;
    }
}