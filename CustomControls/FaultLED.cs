using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class FaultLed : UserControl
    {
        public FaultLed()
        {
            InitializeComponent();
        }

        public void SetFaultLed(bool? alarm1, bool? alarm2)
        {
            picBox1.Image = alarm1 == true ? Properties.Resources.green_led : Properties.Resources.red_led;
            picBox2.Image = alarm2 == true ? Properties.Resources.green_led : Properties.Resources.red_led;
        }

        private void FaultLED_SizeChanged(object sender, EventArgs e)
        {
            Width = Height * 2;
            picBox1.Size = new Size(Height, Height);
            picBox2.Size = new Size(Height, Height);
            picBox2.Location = new Point(Height, 0);
        }
    }
}