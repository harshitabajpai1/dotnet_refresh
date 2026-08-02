namespace CSharpProgrammingChallenges;

public class BankTransactionCalculator
{
    public static int CalculateFinalBalance(int initialBalance, int[] transactions)
    {
        int balance = initialBalance;

        foreach (int transaction in transactions)
        {
            if (transaction >= 0)
            {
                balance += transaction;
            }
            else
            {
                if (balance + transaction >= 0)
                    balance += transaction;
            }
        }

        return balance;
    }
}

