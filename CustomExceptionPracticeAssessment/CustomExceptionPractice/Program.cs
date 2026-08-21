using System;
using CustomExeption;

class Program
{
    public static void Main(string[] args)
    {
        EntryUtility employeeObj = new EntryUtility();
        Console.WriteLine("Enter the number of entries");
        int n = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            try
            {
                Console.WriteLine($"\nEntry {i + 1}:");
                Console.Write("Enter the details: ");
                string detail = Console.ReadLine();

                string[] parts = detail.Split(':');
                
                string employeeId = parts[0];
                string entryType = parts[1];
                int duration = Int32.Parse(parts[2]);

                //validate employee id
                if (employeeObj.validateEmployeeId(employeeId))
                {
                    Console.WriteLine("Employee ID is valid.");
                }


                if (employeeObj.validDuration(duration))
                {
                    Console.WriteLine("Duration is valid.");
                }
            }
            catch (InvalidEntryException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

    }
}
