using System;

namespace AlarmFunction
{
    public class PowerAlarm : IPowerAlarm
    {
        private readonly decimal? _curValue;
        private readonly string _powerName;
        private readonly decimal? _preValue;
        private readonly decimal _threshold;

        public PowerAlarm(string powerName, decimal? preValue, decimal? curValue, decimal threshold)
        {
            _powerName = powerName;
            _preValue = preValue;
            _curValue = curValue;
            _threshold = threshold;
        }

        public string CheckPowerName { get; set; }

        public string ValueJumpAlarm()
        {
            if (_preValue != null && _curValue != null)
            {
                decimal outburstValue = Math.Abs((decimal)(_curValue - _preValue));
                if (outburstValue > _threshold)
                {
                    CheckPowerName = _powerName;
                    string msg = string.Format("{0}跳变{1}", _powerName, outburstValue);
                    return msg;
                }
            }
            return null;
        }
    }
}