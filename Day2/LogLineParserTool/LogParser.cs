using System;

static class LogParser
{
    // Read the log line through a readonly input reference.
    public static void ParseLogLine(in string logLine, out DateTime timestamp, out LogLevel level, ref int counter)
    {
        // Expected format: "2023-10-27 14:30:00 ERROR: Disk full".
        string[] parts = logLine.Split(new char[] { ' ' }, 3);

        string datePart = parts[0] + " " + parts[1];
        DateTime.TryParse(datePart, out timestamp);

        string levelPart = parts[2].Split(':')[0].Trim();

        if (!Enum.TryParse(levelPart, true, out level))
        {
            level = LogLevel.Info;
        }

        counter = counter + 1;
    }
}

