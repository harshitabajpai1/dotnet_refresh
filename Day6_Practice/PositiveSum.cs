public class PositiveSum
{
    public int SumUntilZero(int[] nums)
    {
        int sum = 0;

        foreach (int n in nums)
        {
            if (n == 0)
                break;

            if (n < 0)
                continue;

            sum += n;
        }

        return sum;
    }
}
