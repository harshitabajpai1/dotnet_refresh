using System;

interface IElectricityBillCalculator
{
    double CalculateBill(double units, double rate, double fixedCharges);
}

class ResidentialCustomer : IElectricityBillCalculator
{
    public double CalculateBill(double units, double rate, double fixedCharges)
    {
        // Calculate the residential charge from usage and fixed fees.
        double bill = (units * rate) + fixedCharges;
        return bill;
    }
}

class CommercialCustomer : IElectricityBillCalculator
{
    public double CalculateBill(double units, double rate, double fixedCharges)
    {
        // Add the commercial surcharge after the base charge is known.
        double baseBill = (units * rate) + fixedCharges;
        double surcharge = baseBill * 0.20;
        return baseBill + surcharge;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Customer Type (Residential/Commercial): ");
        string customerType = Console.ReadLine();

        Console.Write("Enter Units Consumed: ");
        string unitsInput = Console.ReadLine();

        Console.Write("Enter Rate per unit: ");
        string rateInput = Console.ReadLine();

        Console.Write("Enter Fixed Charges: ");
        string fixedInput = Console.ReadLine();

        // Ensure unit consumption is valid before billing.
        if (!double.TryParse(unitsInput, out double units) || units < 0)
        {
            Console.WriteLine("Invalid units entered. Must be non-negative number.");
            return;
        }

        // Ensure the supplied unit rate can be used.
        if (!double.TryParse(rateInput, out double rate) || rate < 0)
        {
            Console.WriteLine("Invalid rate entered. Must be non-negative number.");
            return;
        }

        // Confirm fixed charges are acceptable.
        if (!double.TryParse(fixedInput, out double fixedCharges) || fixedCharges < 0)
        {
            Console.WriteLine("Invalid fixed charges entered.");
            return;
        }

        IElectricityBillCalculator calculator;

        // Select the calculator for the requested customer category.
        if (customerType.Trim().ToLower() == "residential")
        {
            calculator = new ResidentialCustomer();
        }
        else if (customerType.Trim().ToLower() == "commercial")
        {
            calculator = new CommercialCustomer();
        }
        else
        {
            Console.WriteLine("Invalid customer type. Please enter Residential or Commercial.");
            return;
        }

        double finalBill = calculator.CalculateBill(units, rate, fixedCharges);
        finalBill = Math.Round(finalBill, 2);

        Console.WriteLine();
        Console.WriteLine("Final Bill Amount: " + finalBill);
    }
}
