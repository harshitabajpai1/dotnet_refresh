using System;
using System.Collections.Generic;

static class OrderProcessor
{
    // Return valid ISBN values from comma-separated entries.
    public static bool TryProcessOrder(out List<string> validIsbns, params string[] isbnEntries)
    {
        validIsbns = new List<string>();

        foreach (string entry in isbnEntries)
        {
            // Split entries that contain several ISBN values.
            string[] splitEntries = entry.Split(',');

            foreach (string single in splitEntries)
            {
                string trimmed = single.Trim();

                if (IsbnValidator.TryParseIsbn(trimmed, out string cleaned))
                {
                    validIsbns.Add(cleaned);
                }
                // Skip invalid ISBN values without throwing.
            }
        }

        return validIsbns.Count > 0;
    }
}

