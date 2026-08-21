using System;
public class FeetToCenti
{
    int feet;

    public FeetToCenti(int feet)
    {
        this.feet = feet;
    }
    public double FeetToCentimeter(int feet)
    {
        double centi = (double)feet * 30.48;
        return Math.Round(centi, 2, MidpointRounding.AwayFromZero);
    }
}