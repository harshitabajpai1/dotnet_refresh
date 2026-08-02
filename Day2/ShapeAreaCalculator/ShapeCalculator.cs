using System;

static class ShapeCalculator
{
    // Calculate a circle area.
    public static double CalculateArea(double radius, int decimals = 2)
    {
        double area = Math.PI * radius * radius;
        return Math.Round(area, decimals);
    }

    // Calculate a rectangle area overload.
    public static double CalculateArea(double length, double width)
    {
        return length * width;
    }

    // Calculate a triangle area overload.
    public static double CalculateArea(double baseLength, double height, bool isTriangle)
    {
        return 0.5 * baseLength * height;
    }
}

