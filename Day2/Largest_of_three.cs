using System;
namespace MyConsoleApp.Day2;
public class Largest_of_three
{
    public static void largest_main()
    {
        int a,b,c;
        Console.Write("Enter a: ");
        a = Int32.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        b = Int32.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        c = Int32.Parse(Console.ReadLine());

        if (a > c)
        {
            if(a>b) Console.WriteLine("a is largest");
            else Console.WriteLine("b is largest");
        }
        else if (c > a)
        {
            if(c>b) Console.WriteLine("c is largest");
            else Console.WriteLine("b is largest");
        }
        else
        {
            Console.WriteLine("enter valid number");
        }
    }
}