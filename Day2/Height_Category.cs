using System;

namespace MyConsoleApp.Day2;

    public class Height_Category
    {
        public static void HeightMain()
        {
            Console.Write("Enter height in cm: ");

            int height;
            // while (!int.TryParse(Console.ReadLine(), out height))
            // {
            //     Console.Write("Enter valid number: ");
            // }
            height = Int32.Parse(Console.ReadLine());

            if (height < 150)
                Console.WriteLine("Dwarf");
            else if (height < 165)
                Console.WriteLine("Average");
            else if (height <= 190)
                Console.WriteLine("Tall");
            else
                Console.WriteLine("Abnormal");
        }
    }

