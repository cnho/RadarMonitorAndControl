using Common;
using DataCurveDisplay;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class PowerIndicationUi : UserControl
    {
        public string SqlConnection { get; set; }

        public string StationId { get; set; }

        public PowerIndicationUi()
        {
            InitializeComponent();
        }

        public void SetBackColor(List<string> powerName)
        {
            foreach (var groupboxItem in Controls.OfType<GroupBox>())
            {
                foreach (var powerDislayItem in groupboxItem.Controls.OfType<PowerDisplay>())
                {
                    if (powerName.Count == 0)
                    {
                        powerDislayItem.ValueBackColor = SystemColors.Control;
                    }
                    else
                    {
                        powerDislayItem.ValueBackColor = powerName.Contains(powerDislayItem.Tag.ToString()) ? Color.Red : SystemColors.Control;
                    }
                }
            }
        }

        public void SetPowerDataValue(RadarPower powerData)
        {
            vol5.Value = powerData.Vol5.ToString();
            vol15.Value = powerData.Vol15.ToString();
            vol_15.Value = powerData.VolNeg15.ToString();
            vol28.Value = powerData.Vol28.ToString();
            vol45.Value = powerData.Vol45.ToString();
            vol510.Value = powerData.Vol510.ToString();
            volNegFila.Value = powerData.VolFilaInve.ToString();
            volFila.Value = powerData.VolFilament.ToString();
            volField.Value = powerData.VolField.ToString();
            volTitPump.Value = powerData.VolTitPump.ToString();
            volEleBeam.Value = powerData.VolEleBeam.ToString();
            volArtifLine.Value = powerData.VolArtifLine.ToString();
            curCatho.Value = powerData.CurCatho.ToString();
            curReversePeak.Value = powerData.CurReversePeak.ToString();
            curFilament.Value = powerData.CurFilament.ToString();
            curFocusCoil.Value = powerData.CurFocusCoil.ToString();
            curTitPump.Value = powerData.CurTitPump.ToString();
            curLeveling.Value = powerData.CurLeveling.ToString();
            curArtifLine.Value = powerData.CurArtifLine.ToString();
        }

        private void vol5_BtnClick(object sender, System.EventArgs e)
        {
            DataLineForm dataLineForm = new DataLineForm
            {
                DataName = "Vol5",
                StationId = StationId,
                ConnectionString = SqlConnection
            };
            dataLineForm.Show();
        }

        private void vol15_BtnClick(object sender, System.EventArgs e)
        {
            DataLineForm dataLineForm = new DataLineForm
            {
                DataName = "Vol15",
                StationId = StationId,
                ConnectionString = SqlConnection
            };
            dataLineForm.Show();
        }

        private void vol_15_BtnClick(object sender, System.EventArgs e)
        {
            DataLineForm dataLineForm = new DataLineForm
            {
                DataName = "VolNeg15",
                StationId = StationId,
                ConnectionString = SqlConnection
            };
            dataLineForm.Show();
        }

        private void vol28_BtnClick(object sender, System.EventArgs e)
        {
            DataLineForm dataLineForm = new DataLineForm
            {
                DataName = "Vol28",
                StationId = StationId,
                ConnectionString = SqlConnection
            };
            dataLineForm.Show();
        }

        private void vol45_BtnClick(object sender, System.EventArgs e)
        {
            DataLineForm dataLineForm = new DataLineForm
            {
                DataName = "Vol45",
                StationId = StationId,
                ConnectionString = SqlConnection
            };
            dataLineForm.Show();
        }

        private void vol510_BtnClick(object sender, System.EventArgs e)
        {
            DataLineForm dataLineForm = new DataLineForm
            {
                DataName = "Vol510",
                StationId = StationId,
                ConnectionString = SqlConnection
            };
            dataLineForm.Show();
        }

        private void volNegFila_BtnClick(object sender, System.EventArgs e)
        {
            DataLineForm dataLineForm = new DataLineForm
            {
                DataName = "VolFilaInve",
                StationId = StationId,
                ConnectionString = SqlConnection
            };
            dataLineForm.Show();
        }

        private void volFila_BtnClick(object sender, System.EventArgs e)
        {
            DataLineForm dataLineForm = new DataLineForm
            {
                DataName = "VolFilament",
                StationId = StationId,
                ConnectionString = SqlConnection
            };
            dataLineForm.Show();
        }

        private void volField_BtnClick(object sender, System.EventArgs e)
        {
            DataLineForm dataLineForm = new DataLineForm
            {
                DataName = "VolField",
                StationId = StationId,
                ConnectionString = SqlConnection
            };
            dataLineForm.Show();
        }

        private void volTitPump_BtnClick(object sender, System.EventArgs e)
        {
            DataLineForm dataLineForm = new DataLineForm
            {
                DataName = "VolTitPump",
                StationId = StationId,
                ConnectionString = SqlConnection
            };
            dataLineForm.Show();
        }

        private void volEleBeam_BtnClick(object sender, System.EventArgs e)
        {
            DataLineForm dataLineForm = new DataLineForm
            {
                DataName = "VolEleBeam",
                StationId = StationId,
                ConnectionString = SqlConnection
            };
            dataLineForm.Show();
        }

        private void volArtifLine_BtnClick(object sender, System.EventArgs e)
        {
            DataLineForm dataLineForm = new DataLineForm
            {
                DataName = "VolArtifLine",
                StationId = StationId,
                ConnectionString = SqlConnection
            };
            dataLineForm.Show();
        }

        private void curCatho_Click(object sender, System.EventArgs e)
        {
            DataLineForm dataLineForm = new DataLineForm
            {
                DataName = "CurCatho",
                StationId = StationId,
                ConnectionString = SqlConnection
            };
            dataLineForm.Show();
        }

        private void curReversePeak_BtnClick(object sender, System.EventArgs e)
        {
            DataLineForm dataLineForm = new DataLineForm
            {
                DataName = "CurReversePeak",
                StationId = StationId,
                ConnectionString = SqlConnection
            };
            dataLineForm.Show();
        }

        private void curFilament_BtnClick(object sender, System.EventArgs e)
        {
            DataLineForm dataLineForm = new DataLineForm
            {
                DataName = "CurFilament",
                StationId = StationId,
                ConnectionString = SqlConnection
            };
            dataLineForm.Show();
        }

        private void curFocusCoil_BtnClick(object sender, System.EventArgs e)
        {
            DataLineForm dataLineForm = new DataLineForm
            {
                DataName = "CurFocusCoil",
                StationId = StationId,
                ConnectionString = SqlConnection
            };
            dataLineForm.Show();
        }

        private void curTitPump_BtnClick(object sender, System.EventArgs e)
        {
            DataLineForm dataLineForm = new DataLineForm
            {
                DataName = "CurTitPump",
                StationId = StationId,
                ConnectionString = SqlConnection
            };
            dataLineForm.Show();
        }

        private void curLeveling_BtnClick(object sender, System.EventArgs e)
        {
            DataLineForm dataLineForm = new DataLineForm
            {
                DataName = "CurLeveling",
                StationId = StationId,
                ConnectionString = SqlConnection
            };
            dataLineForm.Show();
        }

        private void curArtifLine_BtnClick(object sender, System.EventArgs e)
        {
            DataLineForm dataLineForm = new DataLineForm
            {
                DataName = "CurArtifLine",
                StationId = StationId,
                ConnectionString = SqlConnection
            };
            dataLineForm.Show();
        }
    }
}