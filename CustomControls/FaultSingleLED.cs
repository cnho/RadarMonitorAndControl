using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class FaultSingleLed : UserControl
    {
        public FaultSingleLed()
        {
            InitializeComponent();
        }

        public void SetFaultLed(bool? alarm)
        {
            picBox1.Image = alarm == true ? Properties.Resources.green_led : Properties.Resources.red_led;
        }

        private void FaultLED_SizeChanged(object sender, EventArgs e)
        {
            Width = Height;
            picBox1.Size = new Size(Width, Height);
            picBox1.Location = new Point(0, 0);
        }
    }
}