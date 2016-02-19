namespace CustomControls
{
    partial class PowerIndicationUi
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.vol5 = new CustomControls.PowerDisplay();
            this.vol28 = new CustomControls.PowerDisplay();
            this.volArtifLine = new CustomControls.PowerDisplay();
            this.volNegFila = new CustomControls.PowerDisplay();
            this.volField = new CustomControls.PowerDisplay();
            this.volTitPump = new CustomControls.PowerDisplay();
            this.vol510 = new CustomControls.PowerDisplay();
            this.vol15 = new CustomControls.PowerDisplay();
            this.vol_15 = new CustomControls.PowerDisplay();
            this.vol45 = new CustomControls.PowerDisplay();
            this.volEleBeam = new CustomControls.PowerDisplay();
            this.volFila = new CustomControls.PowerDisplay();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.curCatho = new CustomControls.PowerDisplay();
            this.curLeveling = new CustomControls.PowerDisplay();
            this.curArtifLine = new CustomControls.PowerDisplay();
            this.curFocusCoil = new CustomControls.PowerDisplay();
            this.curFilament = new CustomControls.PowerDisplay();
            this.curReversePeak = new CustomControls.PowerDisplay();
            this.curTitPump = new CustomControls.PowerDisplay();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 298);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "电源指示";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.vol5);
            this.groupBox3.Controls.Add(this.vol28);
            this.groupBox3.Controls.Add(this.volArtifLine);
            this.groupBox3.Controls.Add(this.volNegFila);
            this.groupBox3.Controls.Add(this.volField);
            this.groupBox3.Controls.Add(this.volTitPump);
            this.groupBox3.Controls.Add(this.vol510);
            this.groupBox3.Controls.Add(this.vol15);
            this.groupBox3.Controls.Add(this.vol_15);
            this.groupBox3.Controls.Add(this.vol45);
            this.groupBox3.Controls.Add(this.volEleBeam);
            this.groupBox3.Controls.Add(this.volFila);
            this.groupBox3.Location = new System.Drawing.Point(3, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 152);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "电压";
            // 
            // vol5
            // 
            this.vol5.Location = new System.Drawing.Point(7, 22);
            this.vol5.MaximumSize = new System.Drawing.Size(160, 29);
            this.vol5.MinimumSize = new System.Drawing.Size(160, 29);
            this.vol5.Name = "vol5";
            this.vol5.NameText = "+5V电源:";
            this.vol5.Size = new System.Drawing.Size(160, 29);
            this.vol5.TabIndex = 0;
            this.vol5.Tag = "5V电压";
            this.vol5.UnitText = "V";
            this.vol5.Value = "";
            this.vol5.ValueBackColor = System.Drawing.SystemColors.Control;
            this.vol5.BtnClick += new System.EventHandler(this.vol5_BtnClick);
            // 
            // vol28
            // 
            this.vol28.Location = new System.Drawing.Point(7, 51);
            this.vol28.MaximumSize = new System.Drawing.Size(160, 29);
            this.vol28.MinimumSize = new System.Drawing.Size(160, 29);
            this.vol28.Name = "vol28";
            this.vol28.NameText = "+28V电源:";
            this.vol28.Size = new System.Drawing.Size(160, 29);
            this.vol28.TabIndex = 1;
            this.vol28.Tag = "28V电压";
            this.vol28.UnitText = "V";
            this.vol28.Value = "";
            this.vol28.ValueBackColor = System.Drawing.SystemColors.Control;
            this.vol28.BtnClick += new System.EventHandler(this.vol28_BtnClick);
            // 
            // volArtifLine
            // 
            this.volArtifLine.Location = new System.Drawing.Point(327, 109);
            this.volArtifLine.MaximumSize = new System.Drawing.Size(160, 29);
            this.volArtifLine.MinimumSize = new System.Drawing.Size(160, 29);
            this.volArtifLine.Name = "volArtifLine";
            this.volArtifLine.NameText = "人工线充电:";
            this.volArtifLine.Size = new System.Drawing.Size(160, 29);
            this.volArtifLine.TabIndex = 11;
            this.volArtifLine.Tag = "人工线电压";
            this.volArtifLine.Value = "";
            this.volArtifLine.ValueBackColor = System.Drawing.SystemColors.Control;
            this.volArtifLine.BtnClick += new System.EventHandler(this.volArtifLine_BtnClick);
            // 
            // volNegFila
            // 
            this.volNegFila.Location = new System.Drawing.Point(7, 80);
            this.volNegFila.MaximumSize = new System.Drawing.Size(160, 29);
            this.volNegFila.MinimumSize = new System.Drawing.Size(160, 29);
            this.volNegFila.Name = "volNegFila";
            this.volNegFila.NameText = "灯丝逆变:";
            this.volNegFila.Size = new System.Drawing.Size(160, 29);
            this.volNegFila.TabIndex = 2;
            this.volNegFila.Tag = "灯丝逆变电压";
            this.volNegFila.UnitText = "V";
            this.volNegFila.Value = "";
            this.volNegFila.ValueBackColor = System.Drawing.SystemColors.Control;
            this.volNegFila.BtnClick += new System.EventHandler(this.volNegFila_BtnClick);
            // 
            // volField
            // 
            this.volField.Location = new System.Drawing.Point(327, 80);
            this.volField.MaximumSize = new System.Drawing.Size(160, 29);
            this.volField.MinimumSize = new System.Drawing.Size(160, 29);
            this.volField.Name = "volField";
            this.volField.NameText = "磁场电压:";
            this.volField.Size = new System.Drawing.Size(160, 29);
            this.volField.TabIndex = 10;
            this.volField.Tag = "磁场电压";
            this.volField.Value = "";
            this.volField.ValueBackColor = System.Drawing.SystemColors.Control;
            this.volField.BtnClick += new System.EventHandler(this.volField_BtnClick);
            // 
            // volTitPump
            // 
            this.volTitPump.Location = new System.Drawing.Point(7, 109);
            this.volTitPump.MaximumSize = new System.Drawing.Size(160, 29);
            this.volTitPump.MinimumSize = new System.Drawing.Size(160, 29);
            this.volTitPump.Name = "volTitPump";
            this.volTitPump.NameText = "钛泵电压:";
            this.volTitPump.Size = new System.Drawing.Size(160, 29);
            this.volTitPump.TabIndex = 3;
            this.volTitPump.Tag = "钛泵电压";
            this.volTitPump.Value = "";
            this.volTitPump.ValueBackColor = System.Drawing.SystemColors.Control;
            this.volTitPump.BtnClick += new System.EventHandler(this.volTitPump_BtnClick);
            // 
            // vol510
            // 
            this.vol510.Location = new System.Drawing.Point(327, 51);
            this.vol510.MaximumSize = new System.Drawing.Size(160, 29);
            this.vol510.MinimumSize = new System.Drawing.Size(160, 29);
            this.vol510.Name = "vol510";
            this.vol510.NameText = "+510V电源:";
            this.vol510.Size = new System.Drawing.Size(160, 29);
            this.vol510.TabIndex = 9;
            this.vol510.Tag = "510V电压";
            this.vol510.UnitText = "V";
            this.vol510.Value = "";
            this.vol510.ValueBackColor = System.Drawing.SystemColors.Control;
            this.vol510.BtnClick += new System.EventHandler(this.vol510_BtnClick);
            // 
            // vol15
            // 
            this.vol15.Location = new System.Drawing.Point(167, 22);
            this.vol15.MaximumSize = new System.Drawing.Size(160, 29);
            this.vol15.MinimumSize = new System.Drawing.Size(160, 29);
            this.vol15.Name = "vol15";
            this.vol15.NameText = "+15V电源:";
            this.vol15.Size = new System.Drawing.Size(160, 29);
            this.vol15.TabIndex = 4;
            this.vol15.Tag = "15V电压";
            this.vol15.UnitText = "V";
            this.vol15.Value = "";
            this.vol15.ValueBackColor = System.Drawing.SystemColors.Control;
            this.vol15.BtnClick += new System.EventHandler(this.vol15_BtnClick);
            // 
            // vol_15
            // 
            this.vol_15.Location = new System.Drawing.Point(327, 22);
            this.vol_15.MaximumSize = new System.Drawing.Size(160, 29);
            this.vol_15.MinimumSize = new System.Drawing.Size(160, 29);
            this.vol_15.Name = "vol_15";
            this.vol_15.NameText = "-15V电源:";
            this.vol_15.Size = new System.Drawing.Size(160, 29);
            this.vol_15.TabIndex = 8;
            this.vol_15.Tag = "-15V电压";
            this.vol_15.UnitText = "V";
            this.vol_15.Value = "";
            this.vol_15.ValueBackColor = System.Drawing.SystemColors.Control;
            this.vol_15.BtnClick += new System.EventHandler(this.vol_15_BtnClick);
            // 
            // vol45
            // 
            this.vol45.Location = new System.Drawing.Point(167, 51);
            this.vol45.MaximumSize = new System.Drawing.Size(160, 29);
            this.vol45.MinimumSize = new System.Drawing.Size(160, 29);
            this.vol45.Name = "vol45";
            this.vol45.NameText = "+45V电源:";
            this.vol45.Size = new System.Drawing.Size(160, 29);
            this.vol45.TabIndex = 5;
            this.vol45.Tag = "45V电压";
            this.vol45.UnitText = "V";
            this.vol45.Value = "";
            this.vol45.ValueBackColor = System.Drawing.SystemColors.Control;
            this.vol45.BtnClick += new System.EventHandler(this.vol45_BtnClick);
            // 
            // volEleBeam
            // 
            this.volEleBeam.Location = new System.Drawing.Point(167, 109);
            this.volEleBeam.MaximumSize = new System.Drawing.Size(160, 29);
            this.volEleBeam.MinimumSize = new System.Drawing.Size(160, 29);
            this.volEleBeam.Name = "volEleBeam";
            this.volEleBeam.NameText = "电子注电压:";
            this.volEleBeam.Size = new System.Drawing.Size(160, 29);
            this.volEleBeam.TabIndex = 7;
            this.volEleBeam.Tag = "电子注电压";
            this.volEleBeam.Value = "";
            this.volEleBeam.ValueBackColor = System.Drawing.SystemColors.Control;
            this.volEleBeam.BtnClick += new System.EventHandler(this.volEleBeam_BtnClick);
            // 
            // volFila
            // 
            this.volFila.Location = new System.Drawing.Point(167, 80);
            this.volFila.MaximumSize = new System.Drawing.Size(160, 29);
            this.volFila.MinimumSize = new System.Drawing.Size(160, 29);
            this.volFila.Name = "volFila";
            this.volFila.NameText = "灯丝电压:";
            this.volFila.Size = new System.Drawing.Size(160, 29);
            this.volFila.TabIndex = 6;
            this.volFila.Tag = "灯丝电压";
            this.volFila.UnitText = "V";
            this.volFila.Value = "";
            this.volFila.ValueBackColor = System.Drawing.SystemColors.Control;
            this.volFila.BtnClick += new System.EventHandler(this.volFila_BtnClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.curCatho);
            this.groupBox2.Controls.Add(this.curLeveling);
            this.groupBox2.Controls.Add(this.curArtifLine);
            this.groupBox2.Controls.Add(this.curFocusCoil);
            this.groupBox2.Controls.Add(this.curFilament);
            this.groupBox2.Controls.Add(this.curReversePeak);
            this.groupBox2.Controls.Add(this.curTitPump);
            this.groupBox2.Location = new System.Drawing.Point(3, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 114);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "电流";
            // 
            // curCatho
            // 
            this.curCatho.Location = new System.Drawing.Point(7, 19);
            this.curCatho.MaximumSize = new System.Drawing.Size(160, 29);
            this.curCatho.MinimumSize = new System.Drawing.Size(160, 29);
            this.curCatho.Name = "curCatho";
            this.curCatho.NameText = "阴极电流:";
            this.curCatho.Size = new System.Drawing.Size(160, 29);
            this.curCatho.TabIndex = 4;
            this.curCatho.Tag = "阴极电流";
            this.curCatho.UnitText = "mA";
            this.curCatho.Value = "";
            this.curCatho.ValueBackColor = System.Drawing.SystemColors.Control;
            this.curCatho.BtnClick += new System.EventHandler(this.curCatho_Click);
            // 
            // curLeveling
            // 
            this.curLeveling.Location = new System.Drawing.Point(327, 48);
            this.curLeveling.MaximumSize = new System.Drawing.Size(160, 29);
            this.curLeveling.MinimumSize = new System.Drawing.Size(160, 29);
            this.curLeveling.Name = "curLeveling";
            this.curLeveling.NameText = "校平电流:";
            this.curLeveling.Size = new System.Drawing.Size(160, 29);
            this.curLeveling.TabIndex = 15;
            this.curLeveling.Tag = "校平电流";
            this.curLeveling.UnitText = "mA";
            this.curLeveling.Value = "";
            this.curLeveling.ValueBackColor = System.Drawing.SystemColors.Control;
            this.curLeveling.BtnClick += new System.EventHandler(this.curLeveling_BtnClick);
            // 
            // curArtifLine
            // 
            this.curArtifLine.Location = new System.Drawing.Point(7, 77);
            this.curArtifLine.MaximumSize = new System.Drawing.Size(160, 29);
            this.curArtifLine.MinimumSize = new System.Drawing.Size(160, 29);
            this.curArtifLine.Name = "curArtifLine";
            this.curArtifLine.NameText = "人工线充电:";
            this.curArtifLine.Size = new System.Drawing.Size(160, 29);
            this.curArtifLine.TabIndex = 6;
            this.curArtifLine.Tag = "人工线电流";
            this.curArtifLine.UnitText = "A";
            this.curArtifLine.Value = "";
            this.curArtifLine.ValueBackColor = System.Drawing.SystemColors.Control;
            this.curArtifLine.BtnClick += new System.EventHandler(this.curArtifLine_BtnClick);
            // 
            // curFocusCoil
            // 
            this.curFocusCoil.Location = new System.Drawing.Point(7, 48);
            this.curFocusCoil.MaximumSize = new System.Drawing.Size(160, 29);
            this.curFocusCoil.MinimumSize = new System.Drawing.Size(160, 29);
            this.curFocusCoil.Name = "curFocusCoil";
            this.curFocusCoil.NameText = "聚焦线圈:";
            this.curFocusCoil.Size = new System.Drawing.Size(160, 29);
            this.curFocusCoil.TabIndex = 5;
            this.curFocusCoil.Tag = "聚焦线圈电流";
            this.curFocusCoil.UnitText = "A";
            this.curFocusCoil.Value = "";
            this.curFocusCoil.ValueBackColor = System.Drawing.SystemColors.Control;
            this.curFocusCoil.BtnClick += new System.EventHandler(this.curFocusCoil_BtnClick);
            // 
            // curFilament
            // 
            this.curFilament.Location = new System.Drawing.Point(327, 19);
            this.curFilament.MaximumSize = new System.Drawing.Size(160, 29);
            this.curFilament.MinimumSize = new System.Drawing.Size(160, 29);
            this.curFilament.Name = "curFilament";
            this.curFilament.NameText = "灯丝电流:";
            this.curFilament.Size = new System.Drawing.Size(160, 29);
            this.curFilament.TabIndex = 14;
            this.curFilament.Tag = "灯丝电流";
            this.curFilament.UnitText = "A";
            this.curFilament.Value = "";
            this.curFilament.ValueBackColor = System.Drawing.SystemColors.Control;
            this.curFilament.BtnClick += new System.EventHandler(this.curFilament_BtnClick);
            // 
            // curReversePeak
            // 
            this.curReversePeak.Location = new System.Drawing.Point(167, 19);
            this.curReversePeak.MaximumSize = new System.Drawing.Size(160, 29);
            this.curReversePeak.MinimumSize = new System.Drawing.Size(160, 29);
            this.curReversePeak.Name = "curReversePeak";
            this.curReversePeak.NameText = "反峰电流:";
            this.curReversePeak.Size = new System.Drawing.Size(160, 29);
            this.curReversePeak.TabIndex = 12;
            this.curReversePeak.Tag = "反峰电流";
            this.curReversePeak.UnitText = "mA";
            this.curReversePeak.Value = "";
            this.curReversePeak.ValueBackColor = System.Drawing.SystemColors.Control;
            this.curReversePeak.BtnClick += new System.EventHandler(this.curReversePeak_BtnClick);
            // 
            // curTitPump
            // 
            this.curTitPump.Location = new System.Drawing.Point(167, 48);
            this.curTitPump.MaximumSize = new System.Drawing.Size(160, 29);
            this.curTitPump.MinimumSize = new System.Drawing.Size(160, 29);
            this.curTitPump.Name = "curTitPump";
            this.curTitPump.NameText = "钛泵电流:";
            this.curTitPump.Size = new System.Drawing.Size(160, 29);
            this.curTitPump.TabIndex = 13;
            this.curTitPump.Tag = "钛泵电流";
            this.curTitPump.UnitText = "uA";
            this.curTitPump.Value = "";
            this.curTitPump.ValueBackColor = System.Drawing.SystemColors.Control;
            this.curTitPump.BtnClick += new System.EventHandler(this.curTitPump_BtnClick);
            // 
            // PowerIndicationUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(500, 298);
            this.MinimumSize = new System.Drawing.Size(500, 298);
            this.Name = "PowerIndicationUi";
            this.Size = new System.Drawing.Size(500, 298);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomControls.PowerDisplay curLeveling;
        private CustomControls.PowerDisplay curFilament;
        private CustomControls.PowerDisplay curTitPump;
        private CustomControls.PowerDisplay curReversePeak;
        private CustomControls.PowerDisplay volArtifLine;
        private CustomControls.PowerDisplay curArtifLine;
        private CustomControls.PowerDisplay volField;
        private CustomControls.PowerDisplay curFocusCoil;
        private CustomControls.PowerDisplay vol510;
        private CustomControls.PowerDisplay curCatho;
        private CustomControls.PowerDisplay vol_15;
        private CustomControls.PowerDisplay volEleBeam;
        private CustomControls.PowerDisplay volFila;
        private CustomControls.PowerDisplay vol45;
        private CustomControls.PowerDisplay vol15;
        private CustomControls.PowerDisplay volTitPump;
        private CustomControls.PowerDisplay volNegFila;
        private CustomControls.PowerDisplay vol28;
        private CustomControls.PowerDisplay vol5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
