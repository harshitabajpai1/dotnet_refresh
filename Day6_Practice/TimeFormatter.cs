public class TimeFormatter
{
    public string FormatSeconds(int totalSeconds)
    {
        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;

        return minutes + ":" + seconds.ToString("D2");
    }
}
