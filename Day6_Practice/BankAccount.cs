public class BankAccount
{
    public int GetFinalBalance(int initialBalance, int[] transactions)
    {
        int balance = initialBalance;

        foreach (int t in transactions)
        {
            if (t >= 0)
            {
                balance += t;
            }
            else
            {
                if (balance + t >= 0)
                    balance += t;
            }
        }

        return balance;
    }
}
