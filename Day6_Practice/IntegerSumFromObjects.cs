public class IntegerSumFromObjects
{
    public int SumIntegers(object[] values)
    {
        int sum = 0;

        foreach (object obj in values)
        {
            if (obj is int x)
            {
                sum += x;
            }
        }

        return sum;
    }
}
