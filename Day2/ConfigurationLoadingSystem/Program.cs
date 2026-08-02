using System;

class Program
{
    static void Main()
    {
        var envSource = new EnvironmentVariableSource();
        var jsonSource = new JsonFileSource("config.json");
        var dbSource = new DatabaseSource();

        bool loaded = ConfigurationLoadCoordinator.TryLoadConfiguration(out string config, envSource, jsonSource, dbSource);

        if (loaded)
        {
            Console.WriteLine("Successfully loaded configuration: " + config);
        }
        else
        {
            Console.WriteLine("All sources failed to load configuration.");
        }
    }
}

