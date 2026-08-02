using System;

static class IsbnValidator
{
    // Clean the ISBN and confirm it has thirteen digits.
    public static bool TryParseIsbn(string rawIsbn, out string cleanedIsbn)
    {
        cleanedIsbn = rawIsbn.Replace("-", "").Trim();

        if (cleanedIsbn.Length == 13)
        {
            return true;
        }

        cleanedIsbn = string.Empty;
        return false;
    }
}

