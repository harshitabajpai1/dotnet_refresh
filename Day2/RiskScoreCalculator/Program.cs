using System;

class Program
{
    static void Main()
    {
        int score = TransactionRiskCalculator.CalculateRiskScore("TX001");
        Console.WriteLine("Risk Score: " + score);

        // Include an invalid transaction id in the sample run.
        int invalidScore = TransactionRiskCalculator.CalculateRiskScore("bad-id");
        Console.WriteLine("Risk Score for invalid id: " + invalidScore);
    }
}

