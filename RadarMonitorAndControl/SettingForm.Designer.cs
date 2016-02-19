namespace RadarMonitorAndControl
{
    partial class SettingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nUdIntl = new System.Windows.Forms.NumericUpDown();
            this.gbDataBase = new System.Windows.Forms.GroupBox();
            this.tbSqlIp = new CustomControls.IpTextBox();
            this.btnSqlTest = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbDataBase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbCommon = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gbStation = new System.Windows.Forms.GroupBox();
            this.dgvStationList = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbSerialPort = new System.Windows.Forms.GroupBox();
            this.cmbCheckBit = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbStopBit = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUdIntl)).BeginInit();
            this.gbDataBase.SuspendLayout();
            this.gbCommon.SuspendLayout();
            this.gbStation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationList)).BeginInit();
            this.gbSerialPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbGrade
            // 
            this.cmbGrade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Items.AddRange(new object[] {
            "省级监控",
            "台站采集"});
            this.cmbGrade.Location = new System.Drawing.Point(98, 19);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(78, 22);
            this.cmbGrade.TabIndex = 0;
            this.cmbGrade.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmb_DrawItem);
            this.cmbGrade.SelectedIndexChanged += new System.EventHandler(this.cmbGrade_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "使用级别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "数据采集间隔：";
            // 
            // nUdIntl
            // 
            this.nUdIntl.Location = new System.Drawing.Point(271, 19);
            this.nUdIntl.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUdIntl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUdIntl.Name = "nUdIntl";
            this.nUdIntl.Size = new System.Drawing.Size(41, 21);
            this.nUdIntl.TabIndex = 1;
            this.nUdIntl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gbDataBase
            // 
            this.gbDataBase.Controls.Add(this.tbSqlIp);
            this.gbDataBase.Controls.Add(this.btnSqlTest);
            this.gbDataBase.Controls.Add(this.tbPassword);
            this.gbDataBase.Controls.Add(this.tbUser);
            this.gbDataBase.Controls.Add(this.tbDataBase);
            this.gbDataBase.Controls.Add(this.label6);
            this.gbDataBase.Controls.Add(this.label5);
            this.gbDataBase.Controls.Add(this.label4);
            this.gbDataBase.Controls.Add(this.label3);
            this.gbDataBase.Location = new System.Drawing.Point(11, 156);
            this.gbDataBase.Name = "gbDataBase";
            this.gbDataBase.Size = new System.Drawing.Size(371, 84);
            this.gbDataBase.TabIndex = 2;
            this.gbDataBase.TabStop = false;
            this.gbDataBase.Text = "数据库参数";
            // 
            // tbSqlIp
            // 
            this.tbSqlIp.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSqlIp.Location = new System.Drawing.Point(71, 23);
            this.tbSqlIp.Name = "tbSqlIp";
            this.tbSqlIp.Size = new System.Drawing.Size(111, 21);
            this.tbSqlIp.TabIndex = 5;
            this.tbSqlIp.Text = "0.0.0.0";
            // 
            // btnSqlTest
            // 
            this.btnSqlTest.Location = new System.Drawing.Point(299, 49);
            this.btnSqlTest.Name = "btnSqlTest";
            this.btnSqlTest.Size = new System.Drawing.Size(41, 23);
            this.btnSqlTest.TabIndex = 4;
            this.btnSqlTest.Text = "测试";
            this.btnSqlTest.UseVisualStyleBackColor = true;
            this.btnSqlTest.Click += new System.EventHandler(this.btnSqlTest_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(241, 50);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '#';
            this.tbPassword.Size = new System.Drawing.Size(53, 21);
            this.tbPassword.TabIndex = 3;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(241, 23);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(99, 21);
            this.tbUser.TabIndex = 2;
            // 
            // tbDataBase
            // 
            this.tbDataBase.Location = new System.Drawing.Point(71, 50);
            this.tbDataBase.Name = "tbDataBase";
            this.tbDataBase.Size = new System.Drawing.Size(111, 21);
            this.tbDataBase.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "密码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "用户名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "库名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "地址：";
            // 
            // gbCommon
            // 
            this.gbCommon.Controls.Add(this.label12);
            this.gbCommon.Controls.Add(this.label1);
            this.gbCommon.Controls.Add(this.cmbGrade);
            this.gbCommon.Controls.Add(this.label2);
            this.gbCommon.Controls.Add(this.nUdIntl);
            this.gbCommon.Location = new System.Drawing.Point(11, 12);
            this.gbCommon.Name = "gbCommon";
            this.gbCommon.Size = new System.Drawing.Size(371, 51);
            this.gbCommon.TabIndex = 0;
            this.gbCommon.TabStop = false;
            this.gbCommon.Text = "通用参数";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(312, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "分钟";
            // 
            // gbStation
            // 
            this.gbStation.Controls.Add(this.dgvStationList);
            this.gbStation.Location = new System.Drawing.Point(12, 246);
            this.gbStation.Name = "gbStation";
            this.gbStation.Size = new System.Drawing.Size(372, 147);
            this.gbStation.TabIndex = 3;
            this.gbStation.TabStop = false;
            this.gbStation.Text = "台站参数";
            // 
            // dgvStationList
            // 
            this.dgvStationList.AllowUserToAddRows = false;
            this.dgvStationList.AllowUserToDeleteRows = false;
            this.dgvStationList.AllowUserToResizeColumns = false;
            this.dgvStationList.AllowUserToResizeRows = false;
            this.dgvStationList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStationList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStationList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStationList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvStationList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStationList.Location = new System.Drawing.Point(3, 17);
            this.dgvStationList.Name = "dgvStationList";
            this.dgvStationList.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvStationList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStationList.RowTemplate.Height = 23;
            this.dgvStationList.Size = new System.Drawing.Size(366, 127);
            this.dgvStationList.TabIndex = 0;
            this.dgvStationList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStationList_CellEndEdit);
            // 
            // Column5
            // 
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "序号";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 70F;
            this.Column1.HeaderText = "站号";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 90F;
            this.Column2.HeaderText = "站名";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 140F;
            this.Column3.HeaderText = "经度";
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.ToolTipText = "格式：dddmmss";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 140F;
            this.Column4.HeaderText = "纬度";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.ToolTipText = "格式：ddmmss";
            // 
            // btnEnter
            // 
            this.btnEnter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEnter.Location = new System.Drawing.Point(98, 399);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "确定";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(222, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbSerialPort
            // 
            this.gbSerialPort.Controls.Add(this.cmbCheckBit);
            this.gbSerialPort.Controls.Add(this.label9);
            this.gbSerialPort.Controls.Add(this.label7);
            this.gbSerialPort.Controls.Add(this.label8);
            this.gbSerialPort.Controls.Add(this.cmbStopBit);
            this.gbSerialPort.Controls.Add(this.cmbDataBits);
            this.gbSerialPort.Controls.Add(this.cmbBaudRate);
            this.gbSerialPort.Controls.Add(this.cmbSerialPort);
            this.gbSerialPort.Controls.Add(this.label10);
            this.gbSerialPort.Controls.Add(this.label11);
            this.gbSerialPort.Location = new System.Drawing.Point(11, 69);
            this.gbSerialPort.Name = "gbSerialPort";
            this.gbSerialPort.Size = new System.Drawing.Size(371, 81);
            this.gbSerialPort.TabIndex = 1;
            this.gbSerialPort.TabStop = false;
            this.gbSerialPort.Text = "串口参数";
            // 
            // cmbCheckBit
            // 
            this.cmbCheckBit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCheckBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCheckBit.FormattingEnabled = true;
            this.cmbCheckBit.Items.AddRange(new object[] {
            "EVEN",
            "ODD",
            "NONE"});
            this.cmbCheckBit.Location = new System.Drawing.Point(287, 48);
            this.cmbCheckBit.Name = "cmbCheckBit";
            this.cmbCheckBit.Size = new System.Drawing.Size(50, 22);
            this.cmbCheckBit.TabIndex = 4;
            this.cmbCheckBit.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmb_DrawItem);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "校验位：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "停止位：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "数据位：";
            // 
            // cmbStopBit
            // 
            this.cmbStopBit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBit.FormattingEnabled = true;
            this.cmbStopBit.Items.AddRange(new object[] {
            "0",
            "1",
            "1.5",
            "2"});
            this.cmbStopBit.Location = new System.Drawing.Point(183, 48);
            this.cmbStopBit.Name = "cmbStopBit";
            this.cmbStopBit.Size = new System.Drawing.Size(45, 22);
            this.cmbStopBit.TabIndex = 3;
            this.cmbStopBit.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmb_DrawItem);
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cmbDataBits.Location = new System.Drawing.Point(86, 48);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(38, 22);
            this.cmbDataBits.TabIndex = 2;
            this.cmbDataBits.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmb_DrawItem);
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbBaudRate.Location = new System.Drawing.Point(203, 20);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(63, 22);
            this.cmbBaudRate.TabIndex = 1;
            this.cmbBaudRate.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmb_DrawItem);
            // 
            // cmbSerialPort
            // 
            this.cmbSerialPort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSerialPort.FormattingEnabled = true;
            this.cmbSerialPort.Location = new System.Drawing.Point(86, 20);
            this.cmbSerialPort.Name = "cmbSerialPort";
            this.cmbSerialPort.Size = new System.Drawing.Size(58, 22);
            this.cmbSerialPort.TabIndex = 0;
            this.cmbSerialPort.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmb_DrawItem);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "波特率：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "串口号：";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 434);
            this.Controls.Add(this.gbSerialPort);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.gbStation);
            this.Controls.Add(this.gbCommon);
            this.Controls.Add(this.gbDataBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "系统设置";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUdIntl)).EndInit();
            this.gbDataBase.ResumeLayout(false);
            this.gbDataBase.PerformLayout();
            this.gbCommon.ResumeLayout(false);
            this.gbCommon.PerformLayout();
            this.gbStation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationList)).EndInit();
            this.gbSerialPort.ResumeLayout(false);
            this.gbSerialPort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUdIntl;
        private System.Windows.Forms.GroupBox gbDataBase;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbDataBase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbCommon;
        private System.Windows.Forms.GroupBox gbStation;
        private System.Windows.Forms.DataGridView dgvStationList;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbSerialPort;
        private System.Windows.Forms.ComboBox cmbCheckBit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbStopBit;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnSqlTest;
        private CustomControls.IpTextBox tbSqlIp;
    }
}