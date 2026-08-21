using System;
public class HeightCategory
{
    int heightCm;

    public HeightCategory(int heightCm)
    {
        this.heightCm = heightCm;
    }
    public string Category(int heightCm)
    {
        string category = "";
        if(heightCm < 150)
        {
            category = "Short";
        }
        else if(heightCm >= 150 && heightCm < 180)
        {
            category = "Average";
        }
        else if(heightCm >= 180)
        {
            category = "Tall";
        }
        return category;
    }
}