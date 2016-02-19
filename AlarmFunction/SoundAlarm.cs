using System.Media;

namespace AlarmFunction
{
    public class SoundAlarm
    {
        public SoundPlayer SoundPlayer { get; set; }

        public void StartAlarm(string sdpath)
        {
            SoundPlayer = new SoundPlayer(sdpath);
            SoundPlayer.PlayLooping();
        }

        public void StopAlarm()
        {
            SoundPlayer?.Stop();
        }
    }
}