using System;
public class AreaOfCircle
{
    double radius;

    public AreaOfCircle(double radius)
    {
        this.radius=radius;
    }
    public double Area(double radius)
    {
        double area = Math.PI * radius *radius;
        return Math.Round(area, 2, MidpointRounding.AwayFromZero);
    }
}