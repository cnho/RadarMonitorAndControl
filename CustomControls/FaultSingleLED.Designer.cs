namespace CustomControls
{
    partial class FaultSingleLed
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
            this.picBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox1
            // 
            this.picBox1.Image = global::CustomControls.Properties.Resources.green_led;
            this.picBox1.Location = new System.Drawing.Point(0, 0);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(21, 21);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 25;
            this.picBox1.TabStop = false;
            // 
            // FaultSingleLED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picBox1);
            this.MaximumSize = new System.Drawing.Size(256, 128);
            this.MinimumSize = new System.Drawing.Size(21, 21);
            this.Name = "FaultSingleLed";
            this.Size = new System.Drawing.Size(21, 21);
            this.SizeChanged += new System.EventHandler(this.FaultLED_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picBox1;
    }
}
