using System;

static class FinancialCalculator
{
    // Default to ten years with annual compounding.
    public static double CalculateCompoundInterest(double principal, double rate, int time = 10, int compoundingFrequency = 1)
    {
        // Use the standard compound interest formula.
        double amount = principal * Math.Pow((1 + rate / compoundingFrequency), compoundingFrequency * time);
        return Math.Round(amount, 2);
    }
}

