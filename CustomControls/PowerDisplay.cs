using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class PowerDisplay : UserControl
    {
        public PowerDisplay()
        {
            InitializeComponent();
        }

        public event EventHandler BtnClick;

        [DefaultValue("电压电流")]
        public string NameText
        {
            get { return lbName.Text; }
            set { lbName.Text = value; }
        }

        [DefaultValue("kV")]
        public string UnitText
        {
            get { return lbUnit.Text; }
            set { lbUnit.Text = value; }
        }

        public string Value
        {
            get { return tbData.Text; }
            set { tbData.Text = value; }
        }

        public Color ValueBackColor
        {
            get { return tbData.BackColor; }
            set { tbData.BackColor = value; }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (BtnClick != null)
            {
                BtnClick(sender, e);
            }
        }
    }
}