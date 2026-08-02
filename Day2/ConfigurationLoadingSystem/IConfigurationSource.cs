using System;

interface IConfigurationSource
{
    // Each source decides how to retrieve configuration data.
    bool TryLoad(out string configData);
}

