using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace AlarmFunction
{
    public class RadarAlarm
    {
        public bool ProcessAlarm(AlarmData alarmData)
        {
            try
            {
                if (alarmData == null)
                    return false;
                FieldInfo[] classobjs = typeof(AlarmData).GetFields();
                List<string> alarmMsgList = (from classobj in classobjs let value = classobj.GetValue(alarmData) where value != null where !Convert.ToBoolean(value) select classobj.GetCustomAttributes(typeof(DescriptionAttribute), true) into customAttributes select $"{((DescriptionAttribute)customAttributes[0]).Description}").ToList();
                if (alarmMsgList.Count > 0)
                {
                    string oneMsg = string.Join("，", alarmMsgList.ToArray());
                    CommonLogHelper.GetInstance("LogWarn").Warn(oneMsg);
                    return true;
                }
                return false;
            }
            catch
            {
                throw;
            }
        }
    }
}