using System;

static class ArithmeticOperations
{
    // Add two numbers.
    public static int Add(int a, int b)
    {
        return a + b;
    }

    // Add any number of values.
    public static int Add(params int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum = sum + n;
        }
        return sum;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int Multiply(params int[] numbers)
    {
        int product = 1;
        foreach (int n in numbers)
        {
            product = product * n;
        }
        return product;
    }
}

