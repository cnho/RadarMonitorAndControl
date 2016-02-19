namespace CustomControls
{
    partial class PowerDisplay
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
            this.lbUnit = new System.Windows.Forms.Label();
            this.btnShowCurve = new System.Windows.Forms.Button();
            this.tbData = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbUnit);
            this.panel1.Controls.Add(this.btnShowCurve);
            this.panel1.Controls.Add(this.tbData);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 29);
            this.panel1.TabIndex = 0;
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.Location = new System.Drawing.Point(117, 8);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(17, 12);
            this.lbUnit.TabIndex = 3;
            this.lbUnit.Text = "kV";
            this.lbUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnShowCurve
            // 
            this.btnShowCurve.Image = global::CustomControls.Properties.Resources.chart_curve;
            this.btnShowCurve.Location = new System.Drawing.Point(134, 3);
            this.btnShowCurve.Name = "btnShowCurve";
            this.btnShowCurve.Size = new System.Drawing.Size(23, 23);
            this.btnShowCurve.TabIndex = 2;
            this.btnShowCurve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShowCurve.UseVisualStyleBackColor = true;
            this.btnShowCurve.Click += new System.EventHandler(this.Button_Click);
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(72, 4);
            this.tbData.Name = "tbData";
            this.tbData.ReadOnly = true;
            this.tbData.Size = new System.Drawing.Size(45, 21);
            this.tbData.TabIndex = 1;
            this.tbData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(1, 8);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(71, 12);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "人工线充电:";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PowerDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(160, 29);
            this.MinimumSize = new System.Drawing.Size(160, 29);
            this.Name = "PowerDisplay";
            this.Size = new System.Drawing.Size(160, 29);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowCurve;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbUnit;
    }
}
