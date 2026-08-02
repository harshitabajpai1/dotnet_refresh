using System.Text.Json;
using System.Linq;

namespace CSharpProgrammingChallenges;

public record StudentScoreRecord(string Name, int Score);

public class StudentScoreFormatter
{
    public static string FilterAndSerialize(string[] items, int minScore)
    {
        var students = new System.Collections.Generic.List<StudentScoreRecord>();
        
        foreach (string item in items)
        {
            string[] parts = item.Split(':');
            if (parts.Length == 2)
            {
                string name = parts[0];
                if (int.TryParse(parts[1], out int score))
                {
                    students.Add(new StudentScoreRecord(name, score));
                }
            }
        }
        
        var filtered = students
            .Where(s => s.Score >= minScore)
            .OrderByDescending(s => s.Score)
            .ThenBy(s => s.Name)
            .ToList();
        
        return JsonSerializer.Serialize(filtered);
    }
}

