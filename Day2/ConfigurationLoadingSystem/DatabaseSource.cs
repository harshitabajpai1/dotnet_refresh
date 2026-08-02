using System;

class DatabaseSource : IConfigurationSource
{
    public bool TryLoad(out string configData)
    {
        Console.WriteLine("Trying DatabaseSource...");

        // Return sample data in place of a real database call.
        configData = "{ \"AppName\": \"MyApp\", \"Version\": \"1.0\" }";
        return true;
    }
}

