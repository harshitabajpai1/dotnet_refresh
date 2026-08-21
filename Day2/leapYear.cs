using System;
namespace MyConsoleApp.Day2;
public class LeapYear
{
    public static void leap_main()
    {
        Console.Write("Enter the year");
        int year;
        year = Int32.Parse(Console.ReadLine());
        if((year%400 == 0) | (year%4 ==0 & year % 100 != 0))
        {
            Console.WriteLine("Leap Year");
        }
        else
        {
            Console.WriteLine("Not Leap Year");
        }
    }
}