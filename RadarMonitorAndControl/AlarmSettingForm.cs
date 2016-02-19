using Common;
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace RadarMonitorAndControl
{
    public partial class AlarmSettingForm : Form
    {
        public AlarmSettingForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AlarmSettingForm_Load(object sender, EventArgs e)
        {
            try
            {
                PowerAlarmParameter powerAlarmParameter = new PowerAlarmParameter();
                if (!File.Exists(PowerAlarmParameter.PowerConfigPath))
                {
                    PowerAlarmParameter.GenerateXmlFile();
                }
                powerAlarmParameter.GetXmlNodeInfo();
                tbCurArtifLine.Text = ConvertInt2Str(powerAlarmParameter.PowerAlarm.CurArtifLine);
                tbCurCatho.Text = ConvertInt2Str(powerAlarmParameter.PowerAlarm.CurCatho);
                tbCurFilament.Text = ConvertInt2Str(powerAlarmParameter.PowerAlarm.CurFilament);
                tbCurFocusCoil.Text = ConvertInt2Str(powerAlarmParameter.PowerAlarm.CurFocusCoil);
                tbCurLeveling.Text = ConvertInt2Str(powerAlarmParameter.PowerAlarm.CurLeveling);
                tbCurReversePeak.Text = ConvertInt2Str(powerAlarmParameter.PowerAlarm.CurReversePeak);
                tbCurTitPump.Text = ConvertInt2Str(powerAlarmParameter.PowerAlarm.CurTitPump);
                tbVol15.Text = ConvertInt2Str(powerAlarmParameter.PowerAlarm.Vol15);
                tbVol28.Text = ConvertInt2Str(powerAlarmParameter.PowerAlarm.Vol28);
                tbVol45.Text = ConvertInt2Str(powerAlarmParameter.PowerAlarm.Vol45);
                tbVol5.Text = ConvertInt2Str(powerAlarmParameter.PowerAlarm.Vol5);
                tbVol510.Text = ConvertInt2Str(powerAlarmParameter.PowerAlarm.Vol510);
                tbVolArtifLine.Text = ConvertInt2Str(powerAlarmParameter.PowerAlarm.VolArtifLine);
                tbVolEleBeam.Text = ConvertInt2Str(powerAlarmParameter.PowerAlarm.VolEleBeam);
                tbVolField.Text = ConvertInt2Str(powerAlarmParameter.PowerAlarm.VolField);
                tbVolFilaInve.Text = ConvertInt2Str(powerAlarmParameter.PowerAlarm.VolFilaInve);
                tbVolFilament.Text = ConvertInt2Str(powerAlarmParameter.PowerAlarm.VolFilament);
                tbVolNeg15.Text = ConvertInt2Str(powerAlarmParameter.PowerAlarm.VolNeg15);
                tbVolTitPump.Text = ConvertInt2Str(powerAlarmParameter.PowerAlarm.VolTitPump);

                chkVol5.Checked = powerAlarmParameter.PowerEnable.Vol5;
                chkCurArtifLine.Checked = powerAlarmParameter.PowerEnable.CurArtifLine;
                chkCurCatho.Checked = powerAlarmParameter.PowerEnable.CurCatho;
                chkCurFilament.Checked = powerAlarmParameter.PowerEnable.CurFilament;
                chkCurFocusCoil.Checked = powerAlarmParameter.PowerEnable.CurFocusCoil;
                chkCurLeveling.Checked = powerAlarmParameter.PowerEnable.CurLeveling;
                chkCurReversePeak.Checked = powerAlarmParameter.PowerEnable.CurReversePeak;
                chkCurTitPump.Checked = powerAlarmParameter.PowerEnable.CurTitPump;
                chkVol15.Checked = powerAlarmParameter.PowerEnable.Vol15;
                chkVol28.Checked = powerAlarmParameter.PowerEnable.Vol28;
                chkVol45.Checked = powerAlarmParameter.PowerEnable.Vol45;
                chkVol510.Checked = powerAlarmParameter.PowerEnable.Vol510;
                chkVolArtifLine.Checked = powerAlarmParameter.PowerEnable.VolArtifLine;
                chkVolEleBeam.Checked = powerAlarmParameter.PowerEnable.VolEleBeam;
                chkVolField.Checked = powerAlarmParameter.PowerEnable.VolField;
                chkVolFilaInve.Checked = powerAlarmParameter.PowerEnable.VolFilaInve;
                chkVolFilament.Checked = powerAlarmParameter.PowerEnable.VolFilament;
                chkVolNeg15.Checked = powerAlarmParameter.PowerEnable.VolNeg15;
                chkVolTitPump.Checked = powerAlarmParameter.PowerEnable.VolTitPump;
            }
            catch (Exception ex)
            {
                CommonLogHelper.GetInstance("LogError").Error(@"读取电源报警参数过程出错", ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(PowerAlarmParameter.PowerConfigPath))
                {
                    PowerAlarmParameter.GenerateXmlFile();
                }
                PowerAlarmPara powerAlarm = new PowerAlarmPara();
                AlarmEnablePara powerEnable = new AlarmEnablePara();
                powerAlarm.CurArtifLine = ConvertStr2Int(tbCurArtifLine.Text);
                powerAlarm.CurCatho = ConvertStr2Int(tbCurCatho.Text);
                powerAlarm.CurFilament = ConvertStr2Int(tbCurFilament.Text);
                powerAlarm.CurFocusCoil = ConvertStr2Int(tbCurFocusCoil.Text);
                powerAlarm.CurLeveling = ConvertStr2Int(tbCurLeveling.Text);
                powerAlarm.CurReversePeak = ConvertStr2Int(tbCurReversePeak.Text);
                powerAlarm.CurTitPump = ConvertStr2Int(tbCurTitPump.Text);
                powerAlarm.Vol15 = ConvertStr2Int(tbVol15.Text);
                powerAlarm.Vol28 = ConvertStr2Int(tbVol28.Text);
                powerAlarm.Vol45 = ConvertStr2Int(tbVol45.Text);
                powerAlarm.Vol5 = ConvertStr2Int(tbVol5.Text);
                powerAlarm.Vol510 = ConvertStr2Int(tbVol510.Text);
                powerAlarm.VolArtifLine = ConvertStr2Int(tbVolArtifLine.Text);
                powerAlarm.VolEleBeam = ConvertStr2Int(tbVolEleBeam.Text);
                powerAlarm.VolField = ConvertStr2Int(tbVolField.Text);
                powerAlarm.VolFilaInve = ConvertStr2Int(tbVolFilaInve.Text);
                powerAlarm.VolFilament = ConvertStr2Int(tbVolFilament.Text);
                powerAlarm.VolNeg15 = ConvertStr2Int(tbVolNeg15.Text);
                powerAlarm.VolTitPump = ConvertStr2Int(tbVolTitPump.Text);

                powerEnable.Vol5 = chkVol5.Checked;
                powerEnable.CurArtifLine = chkCurArtifLine.Checked;
                powerEnable.CurCatho = chkCurCatho.Checked;
                powerEnable.CurFilament = chkCurFilament.Checked;
                powerEnable.CurFocusCoil = chkCurFocusCoil.Checked;
                powerEnable.CurLeveling = chkCurLeveling.Checked;
                powerEnable.CurReversePeak = chkCurReversePeak.Checked;
                powerEnable.CurTitPump = chkCurTitPump.Checked;
                powerEnable.Vol15 = chkVol15.Checked;
                powerEnable.Vol28 = chkVol28.Checked;
                powerEnable.Vol45 = chkVol45.Checked;
                powerEnable.Vol510 = chkVol510.Checked;
                powerEnable.VolArtifLine = chkVolArtifLine.Checked;
                powerEnable.VolEleBeam = chkVolEleBeam.Checked;
                powerEnable.VolField = chkVolField.Checked;
                powerEnable.VolFilaInve = chkVolFilaInve.Checked;
                powerEnable.VolFilament = chkVolFilament.Checked;
                powerEnable.VolNeg15 = chkVolNeg15.Checked;
                powerEnable.VolTitPump = chkVolTitPump.Checked;
                PowerAlarmParameter.OperateXmlNodeInfo(powerEnable, powerAlarm);
                Close();
            }
            catch (Exception ex)
            {
                CommonLogHelper.GetInstance("LogError").Error(@"保存电源报警参数过程出错", ex);
            }
        }

        private string ConvertInt2Str(decimal i)
        {
            return i == 9999 ? string.Empty : i.ToString(CultureInfo.InvariantCulture);
        }

        private decimal ConvertStr2Int(string s)
        {
            decimal i;
            return decimal.TryParse(s, out i) ? i : 9999;
        }
    }
}