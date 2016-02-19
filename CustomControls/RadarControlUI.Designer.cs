namespace CustomControls
{
    partial class RadarControlUi
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisplayRest = new System.Windows.Forms.Button();
            this.btnManualRest = new System.Windows.Forms.Button();
            this.btnArcTest = new System.Windows.Forms.Button();
            this.btnHvOn = new System.Windows.Forms.Button();
            this.btnHvOff = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnFilaTest = new System.Windows.Forms.Button();
            this.slFault = new CustomControls.StatusLed();
            this.slNo = new CustomControls.StatusLed();
            this.slHVon = new CustomControls.StatusLed();
            this.slHVoff = new CustomControls.StatusLed();
            this.slAuto = new CustomControls.StatusLed();
            this.slManual = new CustomControls.StatusLed();
            this.slBroadPulse = new CustomControls.StatusLed();
            this.slSpikePulse = new CustomControls.StatusLed();
            this.slLoad = new CustomControls.StatusLed();
            this.slAllowOn = new CustomControls.StatusLed();
            this.slRepeatCycle = new CustomControls.StatusLed();
            this.slAntenna = new CustomControls.StatusLed();
            this.slFilaSup = new CustomControls.StatusLed();
            this.slPreheat = new CustomControls.StatusLed();
            this.slLocalCtrl = new CustomControls.StatusLed();
            this.slRemoteCtrl = new CustomControls.StatusLed();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 217);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.slFault);
            this.groupBox1.Controls.Add(this.slNo);
            this.groupBox1.Controls.Add(this.slHVon);
            this.groupBox1.Controls.Add(this.slHVoff);
            this.groupBox1.Controls.Add(this.slAuto);
            this.groupBox1.Controls.Add(this.slManual);
            this.groupBox1.Controls.Add(this.slBroadPulse);
            this.groupBox1.Controls.Add(this.slSpikePulse);
            this.groupBox1.Controls.Add(this.slLoad);
            this.groupBox1.Controls.Add(this.slAllowOn);
            this.groupBox1.Controls.Add(this.slRepeatCycle);
            this.groupBox1.Controls.Add(this.slAntenna);
            this.groupBox1.Controls.Add(this.slFilaSup);
            this.groupBox1.Controls.Add(this.slPreheat);
            this.groupBox1.Controls.Add(this.slLocalCtrl);
            this.groupBox1.Controls.Add(this.slRemoteCtrl);
            this.groupBox1.Controls.Add(this.btnDisplayRest);
            this.groupBox1.Controls.Add(this.btnManualRest);
            this.groupBox1.Controls.Add(this.btnArcTest);
            this.groupBox1.Controls.Add(this.btnHvOn);
            this.groupBox1.Controls.Add(this.btnHvOff);
            this.groupBox1.Controls.Add(this.btnControl);
            this.groupBox1.Controls.Add(this.btnAuto);
            this.groupBox1.Controls.Add(this.btnFilaTest);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "状态指示和操作";
            // 
            // btnDisplayRest
            // 
            this.btnDisplayRest.BackColor = System.Drawing.SystemColors.Window;
            this.btnDisplayRest.Location = new System.Drawing.Point(369, 161);
            this.btnDisplayRest.Name = "btnDisplayRest";
            this.btnDisplayRest.Size = new System.Drawing.Size(50, 50);
            this.btnDisplayRest.TabIndex = 28;
            this.btnDisplayRest.Text = "故障显示复位";
            this.btnDisplayRest.UseVisualStyleBackColor = false;
            this.btnDisplayRest.Click += new System.EventHandler(this.btnDisplayRest_Click);
            // 
            // btnManualRest
            // 
            this.btnManualRest.BackColor = System.Drawing.SystemColors.Window;
            this.btnManualRest.Location = new System.Drawing.Point(273, 161);
            this.btnManualRest.Name = "btnManualRest";
            this.btnManualRest.Size = new System.Drawing.Size(50, 50);
            this.btnManualRest.TabIndex = 26;
            this.btnManualRest.Text = "手动\r\n复位";
            this.btnManualRest.UseVisualStyleBackColor = false;
            this.btnManualRest.Click += new System.EventHandler(this.btnManualRest_Click);
            // 
            // btnArcTest
            // 
            this.btnArcTest.BackColor = System.Drawing.SystemColors.Window;
            this.btnArcTest.Location = new System.Drawing.Point(369, 105);
            this.btnArcTest.Name = "btnArcTest";
            this.btnArcTest.Size = new System.Drawing.Size(50, 50);
            this.btnArcTest.TabIndex = 25;
            this.btnArcTest.Text = "电弧\r\n测试";
            this.btnArcTest.UseVisualStyleBackColor = false;
            this.btnArcTest.Click += new System.EventHandler(this.btnArcTest_Click);
            // 
            // btnHvOn
            // 
            this.btnHvOn.BackColor = System.Drawing.SystemColors.Window;
            this.btnHvOn.Location = new System.Drawing.Point(81, 161);
            this.btnHvOn.Name = "btnHvOn";
            this.btnHvOn.Size = new System.Drawing.Size(50, 50);
            this.btnHvOn.TabIndex = 23;
            this.btnHvOn.Text = "高压开";
            this.btnHvOn.UseVisualStyleBackColor = false;
            this.btnHvOn.Click += new System.EventHandler(this.btnHvOn_Click);
            // 
            // btnHvOff
            // 
            this.btnHvOff.BackColor = System.Drawing.SystemColors.Window;
            this.btnHvOff.Location = new System.Drawing.Point(177, 161);
            this.btnHvOff.Name = "btnHvOff";
            this.btnHvOff.Size = new System.Drawing.Size(50, 50);
            this.btnHvOff.TabIndex = 22;
            this.btnHvOff.Text = "高压关";
            this.btnHvOff.UseVisualStyleBackColor = false;
            this.btnHvOff.Click += new System.EventHandler(this.btnHvOff_Click);
            // 
            // btnControl
            // 
            this.btnControl.BackColor = System.Drawing.SystemColors.Window;
            this.btnControl.Location = new System.Drawing.Point(81, 105);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(50, 50);
            this.btnControl.TabIndex = 19;
            this.btnControl.Text = "本控\r\n遥控";
            this.btnControl.UseVisualStyleBackColor = false;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.BackColor = System.Drawing.SystemColors.Window;
            this.btnAuto.Location = new System.Drawing.Point(177, 105);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(50, 50);
            this.btnAuto.TabIndex = 18;
            this.btnAuto.Text = "自动\r\n手动";
            this.btnAuto.UseVisualStyleBackColor = false;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnFilaTest
            // 
            this.btnFilaTest.BackColor = System.Drawing.SystemColors.Window;
            this.btnFilaTest.Location = new System.Drawing.Point(273, 105);
            this.btnFilaTest.Name = "btnFilaTest";
            this.btnFilaTest.Size = new System.Drawing.Size(50, 50);
            this.btnFilaTest.TabIndex = 17;
            this.btnFilaTest.Text = "灯测试";
            this.btnFilaTest.UseVisualStyleBackColor = false;
            this.btnFilaTest.Click += new System.EventHandler(this.btnFilaTest_Click);
            // 
            // slFault
            // 
            this.slFault.Light = false;
            this.slFault.Location = new System.Drawing.Point(356, 62);
            this.slFault.MaximumSize = new System.Drawing.Size(53, 36);
            this.slFault.MinimumSize = new System.Drawing.Size(53, 36);
            this.slFault.Name = "slFault";
            this.slFault.Size = new System.Drawing.Size(53, 36);
            this.slFault.StatusText = "故障";
            this.slFault.TabIndex = 44;
            // 
            // slNo
            // 
            this.slNo.Light = false;
            this.slNo.Location = new System.Drawing.Point(409, 62);
            this.slNo.MaximumSize = new System.Drawing.Size(53, 36);
            this.slNo.MinimumSize = new System.Drawing.Size(53, 36);
            this.slNo.Name = "slNo";
            this.slNo.Size = new System.Drawing.Size(53, 36);
            this.slNo.StatusText = "";
            this.slNo.TabIndex = 43;
            // 
            // slHVon
            // 
            this.slHVon.Light = false;
            this.slHVon.Location = new System.Drawing.Point(250, 62);
            this.slHVon.MaximumSize = new System.Drawing.Size(53, 36);
            this.slHVon.MinimumSize = new System.Drawing.Size(53, 36);
            this.slHVon.Name = "slHVon";
            this.slHVon.Size = new System.Drawing.Size(53, 36);
            this.slHVon.StatusText = "高压通";
            this.slHVon.TabIndex = 42;
            // 
            // slHVoff
            // 
            this.slHVoff.Light = false;
            this.slHVoff.Location = new System.Drawing.Point(303, 62);
            this.slHVoff.MaximumSize = new System.Drawing.Size(53, 36);
            this.slHVoff.MinimumSize = new System.Drawing.Size(53, 36);
            this.slHVoff.Name = "slHVoff";
            this.slHVoff.Size = new System.Drawing.Size(53, 36);
            this.slHVoff.StatusText = "高压断";
            this.slHVoff.TabIndex = 41;
            // 
            // slAuto
            // 
            this.slAuto.Light = false;
            this.slAuto.Location = new System.Drawing.Point(144, 62);
            this.slAuto.MaximumSize = new System.Drawing.Size(53, 36);
            this.slAuto.MinimumSize = new System.Drawing.Size(53, 36);
            this.slAuto.Name = "slAuto";
            this.slAuto.Size = new System.Drawing.Size(53, 36);
            this.slAuto.StatusText = "自动";
            this.slAuto.TabIndex = 40;
            // 
            // slManual
            // 
            this.slManual.Light = false;
            this.slManual.Location = new System.Drawing.Point(197, 62);
            this.slManual.MaximumSize = new System.Drawing.Size(53, 36);
            this.slManual.MinimumSize = new System.Drawing.Size(53, 36);
            this.slManual.Name = "slManual";
            this.slManual.Size = new System.Drawing.Size(53, 36);
            this.slManual.StatusText = "手动";
            this.slManual.TabIndex = 39;
            // 
            // slBroadPulse
            // 
            this.slBroadPulse.Light = false;
            this.slBroadPulse.Location = new System.Drawing.Point(38, 62);
            this.slBroadPulse.MaximumSize = new System.Drawing.Size(53, 36);
            this.slBroadPulse.MinimumSize = new System.Drawing.Size(53, 36);
            this.slBroadPulse.Name = "slBroadPulse";
            this.slBroadPulse.Size = new System.Drawing.Size(53, 36);
            this.slBroadPulse.StatusText = "宽脉冲";
            this.slBroadPulse.TabIndex = 38;
            // 
            // slSpikePulse
            // 
            this.slSpikePulse.Light = false;
            this.slSpikePulse.Location = new System.Drawing.Point(91, 62);
            this.slSpikePulse.MaximumSize = new System.Drawing.Size(53, 36);
            this.slSpikePulse.MinimumSize = new System.Drawing.Size(53, 36);
            this.slSpikePulse.Name = "slSpikePulse";
            this.slSpikePulse.Size = new System.Drawing.Size(53, 36);
            this.slSpikePulse.StatusText = "窄脉冲";
            this.slSpikePulse.TabIndex = 37;
            // 
            // slLoad
            // 
            this.slLoad.Light = false;
            this.slLoad.Location = new System.Drawing.Point(356, 20);
            this.slLoad.MaximumSize = new System.Drawing.Size(53, 36);
            this.slLoad.MinimumSize = new System.Drawing.Size(53, 36);
            this.slLoad.Name = "slLoad";
            this.slLoad.Size = new System.Drawing.Size(53, 36);
            this.slLoad.StatusText = "负载";
            this.slLoad.TabIndex = 36;
            // 
            // slAllowOn
            // 
            this.slAllowOn.Light = false;
            this.slAllowOn.Location = new System.Drawing.Point(409, 20);
            this.slAllowOn.MaximumSize = new System.Drawing.Size(53, 36);
            this.slAllowOn.MinimumSize = new System.Drawing.Size(53, 36);
            this.slAllowOn.Name = "slAllowOn";
            this.slAllowOn.Size = new System.Drawing.Size(53, 36);
            this.slAllowOn.StatusText = "准加";
            this.slAllowOn.TabIndex = 35;
            // 
            // slRepeatCycle
            // 
            this.slRepeatCycle.Light = false;
            this.slRepeatCycle.Location = new System.Drawing.Point(250, 20);
            this.slRepeatCycle.MaximumSize = new System.Drawing.Size(53, 36);
            this.slRepeatCycle.MinimumSize = new System.Drawing.Size(53, 36);
            this.slRepeatCycle.Name = "slRepeatCycle";
            this.slRepeatCycle.Size = new System.Drawing.Size(53, 36);
            this.slRepeatCycle.StatusText = "重复循环";
            this.slRepeatCycle.TabIndex = 34;
            // 
            // slAntenna
            // 
            this.slAntenna.Light = false;
            this.slAntenna.Location = new System.Drawing.Point(303, 20);
            this.slAntenna.MaximumSize = new System.Drawing.Size(53, 36);
            this.slAntenna.MinimumSize = new System.Drawing.Size(53, 36);
            this.slAntenna.Name = "slAntenna";
            this.slAntenna.Size = new System.Drawing.Size(53, 36);
            this.slAntenna.StatusText = "天线";
            this.slAntenna.TabIndex = 33;
            // 
            // slFilaSup
            // 
            this.slFilaSup.Light = false;
            this.slFilaSup.Location = new System.Drawing.Point(144, 20);
            this.slFilaSup.MaximumSize = new System.Drawing.Size(53, 36);
            this.slFilaSup.MinimumSize = new System.Drawing.Size(53, 36);
            this.slFilaSup.Name = "slFilaSup";
            this.slFilaSup.Size = new System.Drawing.Size(53, 36);
            this.slFilaSup.StatusText = "灯丝供电";
            this.slFilaSup.TabIndex = 32;
            // 
            // slPreheat
            // 
            this.slPreheat.Light = false;
            this.slPreheat.Location = new System.Drawing.Point(197, 20);
            this.slPreheat.MaximumSize = new System.Drawing.Size(53, 36);
            this.slPreheat.MinimumSize = new System.Drawing.Size(53, 36);
            this.slPreheat.Name = "slPreheat";
            this.slPreheat.Size = new System.Drawing.Size(53, 36);
            this.slPreheat.StatusText = "预热";
            this.slPreheat.TabIndex = 31;
            // 
            // slLocalCtrl
            // 
            this.slLocalCtrl.Light = false;
            this.slLocalCtrl.Location = new System.Drawing.Point(38, 20);
            this.slLocalCtrl.MaximumSize = new System.Drawing.Size(53, 36);
            this.slLocalCtrl.MinimumSize = new System.Drawing.Size(53, 36);
            this.slLocalCtrl.Name = "slLocalCtrl";
            this.slLocalCtrl.Size = new System.Drawing.Size(53, 36);
            this.slLocalCtrl.StatusText = "本控";
            this.slLocalCtrl.TabIndex = 30;
            // 
            // slRemoteCtrl
            // 
            this.slRemoteCtrl.Light = false;
            this.slRemoteCtrl.Location = new System.Drawing.Point(91, 20);
            this.slRemoteCtrl.MaximumSize = new System.Drawing.Size(53, 36);
            this.slRemoteCtrl.MinimumSize = new System.Drawing.Size(53, 36);
            this.slRemoteCtrl.Name = "slRemoteCtrl";
            this.slRemoteCtrl.Size = new System.Drawing.Size(53, 36);
            this.slRemoteCtrl.StatusText = "遥控";
            this.slRemoteCtrl.TabIndex = 29;
            // 
            // RadarControlUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(500, 217);
            this.MinimumSize = new System.Drawing.Size(500, 217);
            this.Name = "RadarControlUi";
            this.Size = new System.Drawing.Size(500, 217);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDisplayRest;
        private System.Windows.Forms.Button btnManualRest;
        private System.Windows.Forms.Button btnArcTest;
        private System.Windows.Forms.Button btnHvOn;
        private System.Windows.Forms.Button btnHvOff;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnFilaTest;
        private CustomControls.StatusLed slRemoteCtrl;
        private CustomControls.StatusLed slFault;
        private CustomControls.StatusLed slNo;
        private CustomControls.StatusLed slHVon;
        private CustomControls.StatusLed slHVoff;
        private CustomControls.StatusLed slAuto;
        private CustomControls.StatusLed slManual;
        private CustomControls.StatusLed slBroadPulse;
        private CustomControls.StatusLed slSpikePulse;
        private CustomControls.StatusLed slLoad;
        private CustomControls.StatusLed slAllowOn;
        private CustomControls.StatusLed slRepeatCycle;
        private CustomControls.StatusLed slAntenna;
        private CustomControls.StatusLed slFilaSup;
        private CustomControls.StatusLed slPreheat;
        private CustomControls.StatusLed slLocalCtrl;
    }
}
