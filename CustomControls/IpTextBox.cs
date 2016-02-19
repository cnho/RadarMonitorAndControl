using System.Drawing;
using System.Windows.Forms;

namespace CustomControls
{
    public class IpTextBox : TextBox
    {
        public IpTextBox()
        {
            Font = base.Font;
        }

        public override sealed Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = (Font)value.Clone();
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassName = "SysIPAddress32";
                return cp;
            }
        }

        protected override bool IsInputKey(Keys keyData)
        {
            return (base.IsInputKey(keyData) || keyData == Keys.Left || keyData == Keys.Right);
        }
    }
}