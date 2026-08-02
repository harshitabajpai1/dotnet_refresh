using System;

interface IShippingCostCalculator
{
    double CalculateCost(double weight, double distance);
}

class StandardPackage : IShippingCostCalculator
{
    public double CalculateCost(double weight, double distance)
    {
        // Use the standard package rate.
        return (weight * 5) + (distance * 0.5);
    }
}

class ExpressPackage : IShippingCostCalculator
{
    public double CalculateCost(double weight, double distance)
    {
        // Start from the express base rate.
        double baseCost = (weight * 8) + (distance * 0.8);
        return baseCost * 1.25;
    }
}

class FragilePackage : IShippingCostCalculator
{
    public double CalculateCost(double weight, double distance)
    {
        // Include the fragile handling charge.
        double baseCost = (weight * 6) + (distance * 0.6);
        return baseCost + 150;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Package Type (Standard/Express/Fragile): ");
        string packageType = Console.ReadLine();

        Console.Write("Enter Weight (kg): ");
        string weightInput = Console.ReadLine();

        Console.Write("Enter Distance (km): ");
        string distanceInput = Console.ReadLine();

        // Validate weight and reject unrealistic entries.
        if (!double.TryParse(weightInput, out double weight) || weight <= 0 || weight > 1000)
        {
            Console.WriteLine("Invalid weight entered. Must be between 0 and 1000 kg.");
            return;
        }

        // Confirm distance is positive.
        if (!double.TryParse(distanceInput, out double distance) || distance <= 0)
        {
            Console.WriteLine("Invalid distance entered. Must be a positive number.");
            return;
        }

        IShippingCostCalculator shipping;

        string type = packageType.Trim().ToLower();

        if (type == "standard")
        {
            shipping = new StandardPackage();
        }
        else if (type == "express")
        {
            shipping = new ExpressPackage();
        }
        else if (type == "fragile")
        {
            shipping = new FragilePackage();
        }
        else
        {
            Console.WriteLine("Invalid package type entered.");
            return;
        }

        double cost = shipping.CalculateCost(weight, distance);
        cost = Math.Round(cost, 2);

        Console.WriteLine();
        Console.WriteLine("Shipping Cost: " + cost);
    }
}
