using Common;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class RadarControlUi : UserControl
    {
        public RadarControlUi()
        {
            InitializeComponent();
        }

        public delegate void SendControlCommad(string cmdstr1, string cmdstr2);

        public event SendControlCommad SendCmd;

        public void SetControlStatus(StatusData controlStatusData)
        {
            slLocalCtrl.SetStatusLed(controlStatusData.LocalCtrl);
            slRemoteCtrl.SetStatusLed(controlStatusData.RemoteCtrl);
            slFilaSup.SetStatusLed(controlStatusData.FilaSup);
            slPreheat.SetStatusLed(controlStatusData.Preheat);
            slRepeatCycle.SetStatusLed(controlStatusData.RepeatCycle);
            slAntenna.SetStatusLed(controlStatusData.Antenna);
            slLoad.SetStatusLed(controlStatusData.Load);
            slAllowOn.SetStatusLed(controlStatusData.AllowOn);
            slBroadPulse.SetStatusLed(controlStatusData.BroadPulse);
            slSpikePulse.SetStatusLed(controlStatusData.SpikePulse);
            slAuto.SetStatusLed(controlStatusData.Auto);
            slManual.SetStatusLed(controlStatusData.Manual);
            slHVon.SetStatusLed(controlStatusData.HVon);
            slHVoff.SetStatusLed(controlStatusData.HVoff);
            slFault.SetStatusLed(controlStatusData.Fault);
            slNo.SetStatusLed(controlStatusData.Backup);
        }

        private void btnArcTest_Click(object sender, System.EventArgs e)
        {
            string[] cmds1 = { "20", "20", "00", "FF", "FF", "FF", "FF", "FF" };
            string[] cmds2 = { "00", "20", "00", "FF", "FF", "FF", "FF", "FF" };

            SendCmd?.Invoke(string.Join(" ", cmds1), string.Join(" ", cmds2));
        }

        private void btnAuto_Click(object sender, System.EventArgs e)
        {
            string[] cmds1 = { "40", "40", "00", "FF", "FF", "FF", "FF", "FF" };
            string[] cmds2 = { "00", "40", "00", "FF", "FF", "FF", "FF", "FF" };

            SendCmd?.Invoke(string.Join(" ", cmds1), string.Join(" ", cmds2));
        }

        private void btnControl_Click(object sender, System.EventArgs e)
        {
            string[] cmds1 = { "10", "10", "00", "FF", "FF", "FF", "FF", "FF" };
            string[] cmds2 = { "00", "10", "00", "FF", "FF", "FF", "FF", "FF" };

            SendCmd?.Invoke(string.Join(" ", cmds1), string.Join(" ", cmds2));
        }

        private void btnDisplayRest_Click(object sender, System.EventArgs e)
        {
            string[] cmds1 = { "02", "02", "00", "FF", "FF", "FF", "FF", "FF" };
            string[] cmds2 = { "00", "02", "00", "FF", "FF", "FF", "FF", "FF" };

            SendCmd?.Invoke(string.Join(" ", cmds1), string.Join(" ", cmds2));
        }

        private void btnFilaTest_Click(object sender, System.EventArgs e)
        {
            string[] cmds1 = { "80", "80", "00", "FF", "FF", "FF", "FF", "FF" };
            string[] cmds2 = { "00", "80", "00", "FF", "FF", "FF", "FF", "FF" };

            SendCmd?.Invoke(string.Join(" ", cmds1), string.Join(" ", cmds2));
        }

        private void btnHvOff_Click(object sender, System.EventArgs e)
        {
            string[] cmds1 = { "04", "04", "00", "FF", "FF", "FF", "FF", "FF" };
            string[] cmds2 = { "00", "04", "00", "FF", "FF", "FF", "FF", "FF" };

            SendCmd?.Invoke(string.Join(" ", cmds1), string.Join(" ", cmds2));
        }

        private void btnHvOn_Click(object sender, System.EventArgs e)
        {
            string[] cmds1 = { "08", "08", "00", "FF", "FF", "FF", "FF", "FF" };
            string[] cmds2 = { "00", "08", "00", "FF", "FF", "FF", "FF", "FF" };

            SendCmd?.Invoke(string.Join(" ", cmds1), string.Join(" ", cmds2));
        }

        private void btnManualRest_Click(object sender, System.EventArgs e)
        {
            string[] cmds1 = { "01", "01", "00", "FF", "FF", "FF", "FF", "FF" };
            string[] cmds2 = { "00", "01", "00", "FF", "FF", "FF", "FF", "FF" };

            SendCmd?.Invoke(string.Join(" ", cmds1), string.Join(" ", cmds2));
        }
    }
}