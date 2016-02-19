using SerialPortComm;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RadarMonitorAndControl
{
    public partial class DebugForm : Form
    {
        public SerialPortOperate ThisSerialPort { get; set; }

        private readonly SynchronizationContext _synchContext;

        public DebugForm()
        {
            InitializeComponent();
            _synchContext = SynchronizationContext.Current;
        }

        private void DebugRecDataProcessing(byte[] message, bool debug)
        {
            if (message.Length > 0)
            {
                _synchContext.Post(a =>
                {
                    try
                    {
                        if (debug)
                        {
                            string msg = string.Join(" ", message.Select(x => x.ToString("X2")).ToArray());
                            tbResult.Text += string.Format(@"{0} 接收数据：{1}" + Environment.NewLine,
                                DateTime.Now.ToString(), msg);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(@"数据显示到界面上出错" + ex);
                    }
                }, null);
            }
        }

        private void btnSendCmd_Click(object sender, System.EventArgs e)
        {
            try
            {
                //ThisSerialPort.ReturnCollectorRecData += DebugRecDataProcessing;
                //byte[] cmd = SerialPortCmdCombine.SetBaseCommand("FF", "03");
                string cmd = tbCommand.Text;
                ThisSerialPort.SendCommand(cmd);
                //string msg = string.Join(" ", cmd.Select(x => x.ToString("X2")).ToArray());
                tbResult.Text += string.Format(@"{0} 发送指令：{1}" + Environment.NewLine, DateTime.Now.ToString(), cmd);
            }
            catch (Exception exception)
            {
                tbResult.Text += string.Format(@"{0} Exception：{1}" + Environment.NewLine,
                                   DateTime.Now.ToString(), exception);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbResult.Clear();
        }

        private void DebugForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ThisSerialPort.ReturnCollectorRecData -= DebugRecDataProcessing;
        }
    }
}