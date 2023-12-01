public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        int hours = seconds / 3600;
        int minutes = (seconds % 3600) / 60;
        int remainingSeconds = seconds % 60;

        return $"{hours.ToString().PadLeft(2, '0')}:{minutes.ToString().PadLeft(2, '0')}:{remainingSeconds.ToString().PadLeft(2, '0')}";
    }
}
