namespace AlarmFunction
{
    /// <summary>
    /// 电源报警接口
    /// </summary>
    public interface IPowerAlarm
    {
        string CheckPowerName { get; }

        string ValueJumpAlarm();
    }
}