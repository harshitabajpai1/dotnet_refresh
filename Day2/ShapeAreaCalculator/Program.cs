using System;

class Program
{
    static void Main()
    {
        // Calculate a circle using the default precision.
        double circleArea1 = ShapeCalculator.CalculateArea(5);
        Console.WriteLine("Circle area (default precision): " + circleArea1);

        // Calculate a rectangle area.
        double rectangleArea = ShapeCalculator.CalculateArea(4, 6);
        Console.WriteLine("Rectangle area: " + rectangleArea);

        // Calculate a triangle area.
        double triangleArea = ShapeCalculator.CalculateArea(3, 7, true);
        Console.WriteLine("Triangle area: " + triangleArea);

        // Use a named argument for precision.
        double circleArea2 = ShapeCalculator.CalculateArea(radius: 5, decimals: 4);
        Console.WriteLine("Circle area (custom precision): " + circleArea2);
    }
}

