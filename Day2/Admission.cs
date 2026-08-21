using System;

namespace MyConsoleApp.Day2;

public class Admission
{
    public static void AdmissionCheck()
    {
        int math = int.Parse(Console.ReadLine());
        int phys = int.Parse(Console.ReadLine());
        int chem = int.Parse(Console.ReadLine());

        int total = math + phys + chem;

        if (math >= 65 && phys >= 55 && chem >= 50 &&
            (total >= 180 || math + phys >= 140))
            Console.WriteLine("Eligible");
        else
            Console.WriteLine("Not Eligible");
    }
}
