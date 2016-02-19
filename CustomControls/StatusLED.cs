using System.ComponentModel;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class StatusLed : UserControl
    {
        public StatusLed()
        {
            InitializeComponent();
        }

        [DefaultValue("状态信息")]
        public string StatusText
        {
            get { return lbTips.Text; }
            set { lbTips.Text = value; }
        }

        public bool Light { get; set; }

        public void SetStatusLed(bool? status)
        {
            Light = (status == true);
            picBox.Image = (status == true) ? Properties.Resources.yellow_led : Properties.Resources.grey_led;
        }
    }
}