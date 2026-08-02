using System;

class EnvironmentVariableSource : IConfigurationSource
{
    public bool TryLoad(out string configData)
    {
        // Simulate an unavailable environment setting.
        configData = string.Empty;
        Console.WriteLine("Trying EnvironmentVariableSource...");
        return false;
    }
}

