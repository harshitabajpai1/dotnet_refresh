using System;
public interface IArea
{
    double Area();
}

public abstract class Shape : IArea
{
    public abstract double Area();
}

public class Circle: Shape
{
    double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double Area()
    {
        return Math.PI * radius * radius;
    }
}

public class Rectangle : Shape
{
    double width , length;
    public Rectangle(double width, double length)
    {
        this.width = width;
        this.length = length;
    }

    public override double Area()
    {
        return width * length;
    }
}


public class Triangle : Shape
{
    double baseTri ;
    double height;
    public Triangle(double baseTri, double height)
    {
        this.baseTri = baseTri;
        this.height = height;
    }
    public override double Area()
    {
        return 0.5 * baseTri * height;
    }
}