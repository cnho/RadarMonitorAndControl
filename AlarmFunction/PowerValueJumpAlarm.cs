using Common;
using System.Collections.Generic;
using System.ComponentModel;

namespace AlarmFunction
{
    public class PowerNameCollection
    {
        private readonly string[] _powerName = { "Vol5", "Vol15", "VolNeg15", "Vol28", "Vol45", "Vol510", "VolFilaInve", "VolFilament", "VolField", "VolTitPump", "VolEleBeam", "VolArtifLine", "CurFilament", "CurFocusCoil", "CurLeveling", "CurReversePeak", "CurTitPump", "CurCatho", "CurArtifLine" };

        public int Length => _powerName.Length;

        public string this[int i] => _powerName[i];
    }

    public class PowerValueJumpAlarm
    {
        private readonly AlarmEnablePara _alarmEnablePara;
        private readonly RadarPower _nowPower;
        private readonly PowerAlarmPara _powerAlarmPara;
        private readonly RadarPower _prePower;

        public PowerValueJumpAlarm(RadarPower prePower, RadarPower nowPower, AlarmEnablePara alarmEnablePara, PowerAlarmPara powerAlarmPara)
        {
            _prePower = prePower;
            _nowPower = nowPower;
            _alarmEnablePara = alarmEnablePara;
            _powerAlarmPara = powerAlarmPara;
        }

        public List<string> CheckResultList { get; set; }

        public string ResultMsg { get; set; }

        public void CheckPowerAlarm()
        {
            PowerNameCollection powerNameCollection = new PowerNameCollection();
            List<string> resultMsgList = new List<string>();
            for (int i = 0; i < powerNameCollection.Length; i++)
            {
                string fieldName = powerNameCollection[i];
                bool needCheck = (bool)_alarmEnablePara.GetType().GetField(fieldName).GetValue(_alarmEnablePara);
                if (needCheck)
                {
                    decimal? prePowerData = (decimal?)_prePower.GetType().GetField(fieldName).GetValue(_prePower);
                    decimal? nowPowerData = (decimal?)_nowPower.GetType().GetField(fieldName).GetValue(_nowPower);
                    decimal threshold = (decimal)_powerAlarmPara.GetType().GetField(fieldName).GetValue(_powerAlarmPara);

                    object[] customAttributes = _powerAlarmPara.GetType()
                         .GetField(fieldName)
                         .GetCustomAttributes(typeof(DescriptionAttribute), true);
                    string powerName = ((DescriptionAttribute)customAttributes[0]).Description;

                    PowerAlarm powerAlarm = new PowerAlarm(powerName, prePowerData, nowPowerData, threshold);
                    string resultmsg = powerAlarm.ValueJumpAlarm();
                    if (!string.IsNullOrEmpty(resultmsg))
                    {
                        CheckResultList.Add(powerAlarm.CheckPowerName);
                        resultMsgList.Add(resultmsg);
                    }
                }
            }
            ResultMsg = string.Join("；", resultMsgList.ToArray());
        }
    }
}