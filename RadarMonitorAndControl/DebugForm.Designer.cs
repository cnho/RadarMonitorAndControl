namespace RadarMonitorAndControl
{
    partial class DebugForm
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
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.btnSendCmd = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCommand
            // 
            this.tbCommand.Location = new System.Drawing.Point(12, 13);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(598, 21);
            this.tbCommand.TabIndex = 0;
            // 
            // btnSendCmd
            // 
            this.btnSendCmd.Location = new System.Drawing.Point(616, 12);
            this.btnSendCmd.Name = "btnSendCmd";
            this.btnSendCmd.Size = new System.Drawing.Size(75, 23);
            this.btnSendCmd.TabIndex = 1;
            this.btnSendCmd.Text = "发送";
            this.btnSendCmd.UseVisualStyleBackColor = true;
            this.btnSendCmd.Click += new System.EventHandler(this.btnSendCmd_Click);
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.SystemColors.Window;
            this.tbResult.Location = new System.Drawing.Point(12, 41);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResult.Size = new System.Drawing.Size(760, 427);
            this.tbResult.TabIndex = 2;
            this.tbResult.WordWrap = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(697, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 480);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnSendCmd);
            this.Controls.Add(this.tbCommand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DebugForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "终端调试窗口";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DebugForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.Button btnSendCmd;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnClear;
    }
}