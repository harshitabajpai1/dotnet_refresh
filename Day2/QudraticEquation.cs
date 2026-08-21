using System;
namespace MyConsoleApp.Day2;
public class QuadraticEquation
{
    public static void QuadraticMain()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        double d = b * b - 4 * a * c;

        if (d > 0)
        {
            double r1 = (-b + Math.Sqrt(d)) / (2 * a);
            double r2 = (-b - Math.Sqrt(d)) / (2 * a);

            Console.WriteLine("Two real and distinct roots");
            Console.WriteLine("Root 1 = " + r1);
            Console.WriteLine("Root 2 = " + r2);
        }
        else if (d == 0)
        {
            double r = -b / (2 * a);
            Console.WriteLine("Two real and equal roots");
            Console.WriteLine("Root = " + r);
        }
        else
        {
            Console.WriteLine("No real roots");
        }
    }
}
