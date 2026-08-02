namespace CSharpProgrammingChallenges;

public class MultiplicationTableGenerator
{
    public static int[] GenerateMultiplicationRow(int n, int upto)
    {
        int[] result = new int[upto];
        
        for (int i = 0; i < upto; i++)
        {
            result[i] = n * (i + 1);
        }
        
        return result;
    }
}

