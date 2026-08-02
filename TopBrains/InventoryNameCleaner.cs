using System.Text;

namespace CSharpProgrammingChallenges;

public class InventoryNameCleaner
{
    public static string CleanProductName(string input)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            if (i == 0 || char.ToLower(input[i]) != char.ToLower(input[i - 1]))
                sb.Append(input[i]);
        }

        string trimmed = sb.ToString().Trim();

        var words = trimmed.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
        }

        return string.Join(" ", words);
    }
}

