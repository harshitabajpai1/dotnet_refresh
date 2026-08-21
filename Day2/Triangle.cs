using System;

namespace MyConsoleApp.Day2;

public class Triangle
{
    public static void TriangleType()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a == b && b == c)
            Console.WriteLine("Equilateral");
        else if (a == b || b == c || a == c)
            Console.WriteLine("Isosceles");
        else
            Console.WriteLine("Scalene");
    }
}
