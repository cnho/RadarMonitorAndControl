namespace CustomControls
{
    partial class StatusLed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusLed));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTips = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTips);
            this.panel1.Controls.Add(this.picBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 36);
            this.panel1.TabIndex = 0;
            // 
            // lbTips
            // 
            this.lbTips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTips.Location = new System.Drawing.Point(0, 0);
            this.lbTips.MaximumSize = new System.Drawing.Size(53, 12);
            this.lbTips.MinimumSize = new System.Drawing.Size(53, 12);
            this.lbTips.Name = "lbTips";
            this.lbTips.Size = new System.Drawing.Size(53, 12);
            this.lbTips.TabIndex = 1;
            this.lbTips.Text = "重复循环";
            this.lbTips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox
            // 
            this.picBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(0, 15);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(53, 21);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // StatusLED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(53, 36);
            this.MinimumSize = new System.Drawing.Size(53, 36);
            this.Name = "StatusLed";
            this.Size = new System.Drawing.Size(53, 36);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTips;
        private System.Windows.Forms.PictureBox picBox;
    }
}
