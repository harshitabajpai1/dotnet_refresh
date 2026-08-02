using System;

class Program
{
    static void Main()
    {
        // Use the default compounding options.
        double result1 = FinancialCalculator.CalculateCompoundInterest(10000, 0.05, 10);
        Console.WriteLine("Future Value (annual compounding): " + result1);

        // Override only the compounding frequency with a named argument.
        double result2 = FinancialCalculator.CalculateCompoundInterest(10000, 0.05, 10, compoundingFrequency: 12);
        Console.WriteLine("Future Value (monthly compounding): " + result2);
    }
}

