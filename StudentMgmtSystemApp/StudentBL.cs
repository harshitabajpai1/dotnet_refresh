using System;
namespace StudentMgmtSystemApp;
public class StudentBL
{
    Student sObj = null;
    public StudentBL()
    {
        sObj = new Student();
    }
    public void AcceptStudentDetails()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        System.Console.WriteLine("System Management System");
        System.Console.WriteLine("=====================================");

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        System.Console.WriteLine("Enter your rollNo: ");
    }

    public float CalcAvj()
    {
        sObj.perc= sObj.Total/3;
        return sObj.perc;
    }

    public void CalcResult(out int Total, out float Percentage)
    {
        Total = sObj.Phy+sObj.Chem  + sObj.Maths;
        Percentage = Total/3;
    }

}
