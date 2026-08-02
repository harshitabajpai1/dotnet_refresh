using System;

static class ConfigurationLoadCoordinator
{
    // Try each configuration source and use the first successful result.
    public static bool TryLoadConfiguration(out string finalConfig, params IConfigurationSource[] sources)
    {
        finalConfig = string.Empty;

        foreach (var src in sources)
        {
            if (src.TryLoad(out string data))
            {
                finalConfig = data;
                return true;
            }
            // Continue silently when a source cannot provide data.
        }

        return false;
    }
}

