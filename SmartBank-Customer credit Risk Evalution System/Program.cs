// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter Customer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age");
            int age = Int32.Parse(Console.ReadLine());

            Console.Write("Enter employment type");
            string employmentType = Console.ReadLine();
            
            Console.Write("Enter monthly income: ");
            double income = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter existing credit dues: ");
            double dues = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter credit score: ");
            int score = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of loan defaults: ");
            int defaults = Convert.ToInt32(Console.ReadLine());

            CreditRiskProcessor processor = new CreditRiskProcessor();


            processor.ValidateCustomerDetails(age, employmentType, income, dues, score, defaults);

            double CreditLimit = processor.CalculateCreditLimit(income, dues, score, defaults);

            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("Credit Limit:" + CreditLimit);
        }
        catch(InvalidCreditDataException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
