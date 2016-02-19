namespace RadarMonitorAndControl
{
    partial class CollectorSettingForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbNewPwdConfirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNewPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetPwd = new System.Windows.Forms.Button();
            this.tbOldPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSetAddress = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.cmbCommNum = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numUdDelay = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSetPort = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbOldAddress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRest = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSetEquipId = new System.Windows.Forms.Button();
            this.tbSoftVer = new System.Windows.Forms.TextBox();
            this.tbEquipId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUdDelay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "新密码确认：";
            // 
            // tbNewPwdConfirm
            // 
            this.tbNewPwdConfirm.Location = new System.Drawing.Point(100, 75);
            this.tbNewPwdConfirm.MaxLength = 8;
            this.tbNewPwdConfirm.Name = "tbNewPwdConfirm";
            this.tbNewPwdConfirm.PasswordChar = '$';
            this.tbNewPwdConfirm.Size = new System.Drawing.Size(73, 21);
            this.tbNewPwdConfirm.TabIndex = 14;
            this.tbNewPwdConfirm.Leave += new System.EventHandler(this.tbNewPwdConfirm_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "新密码：";
            // 
            // tbNewPwd
            // 
            this.tbNewPwd.Location = new System.Drawing.Point(100, 46);
            this.tbNewPwd.MaxLength = 8;
            this.tbNewPwd.Name = "tbNewPwd";
            this.tbNewPwd.PasswordChar = '$';
            this.tbNewPwd.Size = new System.Drawing.Size(73, 21);
            this.tbNewPwd.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "旧密码：";
            // 
            // btnSetPwd
            // 
            this.btnSetPwd.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetPwd.Location = new System.Drawing.Point(100, 101);
            this.btnSetPwd.Name = "btnSetPwd";
            this.btnSetPwd.Size = new System.Drawing.Size(75, 23);
            this.btnSetPwd.TabIndex = 10;
            this.btnSetPwd.Text = "设置";
            this.btnSetPwd.UseVisualStyleBackColor = false;
            this.btnSetPwd.Click += new System.EventHandler(this.btnSetPwd_Click);
            // 
            // tbOldPwd
            // 
            this.tbOldPwd.Location = new System.Drawing.Point(100, 19);
            this.tbOldPwd.MaxLength = 8;
            this.tbOldPwd.Name = "tbOldPwd";
            this.tbOldPwd.PasswordChar = '$';
            this.tbOldPwd.Size = new System.Drawing.Size(73, 21);
            this.tbOldPwd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "新地址：";
            // 
            // btnSetAddress
            // 
            this.btnSetAddress.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetAddress.Location = new System.Drawing.Point(89, 75);
            this.btnSetAddress.Name = "btnSetAddress";
            this.btnSetAddress.Size = new System.Drawing.Size(75, 23);
            this.btnSetAddress.TabIndex = 18;
            this.btnSetAddress.Text = "设置";
            this.btnSetAddress.UseVisualStyleBackColor = false;
            this.btnSetAddress.Click += new System.EventHandler(this.btnSetAddress_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(89, 48);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.PasswordChar = '$';
            this.tbAddress.Size = new System.Drawing.Size(73, 21);
            this.tbAddress.TabIndex = 16;
            // 
            // cmbCommNum
            // 
            this.cmbCommNum.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCommNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommNum.FormattingEnabled = true;
            this.cmbCommNum.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmbCommNum.Location = new System.Drawing.Point(97, 18);
            this.cmbCommNum.Name = "cmbCommNum";
            this.cmbCommNum.Size = new System.Drawing.Size(73, 22);
            this.cmbCommNum.TabIndex = 28;
            this.cmbCommNum.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbCommNum_DrawItem);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "串口序号：";
            // 
            // numUdDelay
            // 
            this.numUdDelay.Location = new System.Drawing.Point(97, 102);
            this.numUdDelay.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUdDelay.Name = "numUdDelay";
            this.numUdDelay.Size = new System.Drawing.Size(50, 21);
            this.numUdDelay.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "发送延时：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "地址：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '$';
            this.textBox1.Size = new System.Drawing.Size(73, 21);
            this.textBox1.TabIndex = 24;
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
            this.cmbBaudRate.Location = new System.Drawing.Point(97, 74);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(73, 22);
            this.cmbBaudRate.TabIndex = 22;
            this.cmbBaudRate.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbCommNum_DrawItem);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "波特率：";
            // 
            // btnSetPort
            // 
            this.btnSetPort.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetPort.Location = new System.Drawing.Point(97, 129);
            this.btnSetPort.Name = "btnSetPort";
            this.btnSetPort.Size = new System.Drawing.Size(73, 23);
            this.btnSetPort.TabIndex = 21;
            this.btnSetPort.Text = "设置";
            this.btnSetPort.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbOldAddress);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.btnSetAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 110);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "采集器地址";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "现地址：";
            // 
            // tbOldAddress
            // 
            this.tbOldAddress.Location = new System.Drawing.Point(89, 21);
            this.tbOldAddress.Name = "tbOldAddress";
            this.tbOldAddress.PasswordChar = '$';
            this.tbOldAddress.ReadOnly = true;
            this.tbOldAddress.Size = new System.Drawing.Size(73, 21);
            this.tbOldAddress.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbOldPwd);
            this.groupBox2.Controls.Add(this.btnSetPwd);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbNewPwd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbNewPwdConfirm);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(212, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 162);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "采集器密码";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.cmbCommNum);
            this.groupBox3.Controls.Add(this.btnSetPort);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmbBaudRate);
            this.groupBox3.Controls.Add(this.numUdDelay);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 162);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "采集器通信";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(153, 106);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 30;
            this.label16.Text = "mS";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRest);
            this.groupBox4.Location = new System.Drawing.Point(298, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(107, 78);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "采集器复位";
            // 
            // btnRest
            // 
            this.btnRest.BackColor = System.Drawing.SystemColors.Control;
            this.btnRest.Location = new System.Drawing.Point(16, 30);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(75, 23);
            this.btnRest.TabIndex = 18;
            this.btnRest.Text = "复位";
            this.btnRest.UseVisualStyleBackColor = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSetEquipId);
            this.groupBox5.Controls.Add(this.tbSoftVer);
            this.groupBox5.Controls.Add(this.tbEquipId);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(280, 78);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "采集器基本信息";
            // 
            // btnSetEquipId
            // 
            this.btnSetEquipId.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetEquipId.Location = new System.Drawing.Point(201, 16);
            this.btnSetEquipId.Name = "btnSetEquipId";
            this.btnSetEquipId.Size = new System.Drawing.Size(73, 23);
            this.btnSetEquipId.TabIndex = 22;
            this.btnSetEquipId.Text = "设置";
            this.btnSetEquipId.UseVisualStyleBackColor = false;
            this.btnSetEquipId.Click += new System.EventHandler(this.btnSetEquipId_Click);
            // 
            // tbSoftVer
            // 
            this.tbSoftVer.Location = new System.Drawing.Point(90, 45);
            this.tbSoftVer.Name = "tbSoftVer";
            this.tbSoftVer.ReadOnly = true;
            this.tbSoftVer.Size = new System.Drawing.Size(184, 21);
            this.tbSoftVer.TabIndex = 18;
            // 
            // tbEquipId
            // 
            this.tbEquipId.Location = new System.Drawing.Point(90, 18);
            this.tbEquipId.MaxLength = 16;
            this.tbEquipId.Name = "tbEquipId";
            this.tbEquipId.Size = new System.Drawing.Size(105, 21);
            this.tbEquipId.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "软件版本号：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "设备编号：";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Controls.Add(this.textBox2);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(212, 96);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(193, 110);
            this.groupBox6.TabIndex = 35;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "AD比例系数";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '$';
            this.textBox3.Size = new System.Drawing.Size(73, 21);
            this.textBox3.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '$';
            this.textBox2.Size = new System.Drawing.Size(73, 21);
            this.textBox2.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 31;
            this.label12.Text = "比例系数：";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(96, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "设置";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 29;
            this.label13.Text = "通道号：";
            // 
            // CollectorSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 388);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CollectorSettingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采集器设置";
            this.Load += new System.EventHandler(this.CollectorSettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUdDelay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewPwdConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNewPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetPwd;
        private System.Windows.Forms.TextBox tbOldPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSetAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.ComboBox cmbCommNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numUdDelay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSetPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbOldAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbSoftVer;
        private System.Windows.Forms.TextBox tbEquipId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSetEquipId;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
    }
}