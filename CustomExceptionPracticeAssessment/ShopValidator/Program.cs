// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using TechStore;

class Program
{
    public static void Main(string[] args)
    {
        GadgetValidator gadgetObj = new GadgetValidator();

        Console.WriteLine("Enter the number of gadget entries:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            try
            {
                Console.WriteLine($"\nEnter gadget {i + 1} details:");
                string details = Console.ReadLine();

                // Split input
                string[] parts = details.Split(':');

                string gadgetID = parts[0];
                string gadgetType = parts[1];
                int warranty = int.Parse(parts[2]);

                gadgetObj.ValidateGadgetID(gadgetID);
                gadgetObj.ValidateWarrantyPeriod(warranty);

                Console.WriteLine("Warranty accepted, stock updated");
            }
            catch (InvalidGadgetException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

