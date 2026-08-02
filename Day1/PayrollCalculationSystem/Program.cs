using System;

class Employee
{
    public string Name;
    public double HoursWorked;
    public double HourlyRate;

    public Employee(string name, double hours, double rate)
    {
        Name = name;
        HoursWorked = hours;
        HourlyRate = rate;
    }
}

class PayrollCalculator
{
    // Pay regular hours first, then apply the overtime multiplier.
    public double CalculateGrossPay(Employee emp)
    {
        double regularHours;
        double overtimeHours;

        if (emp.HoursWorked > 40)
        {
            regularHours = 40;
            overtimeHours = emp.HoursWorked - 40;
        }
        else
        {
            regularHours = emp.HoursWorked;
            overtimeHours = 0;
        }

        double regularPay = regularHours * emp.HourlyRate;
        double overtimePay = overtimeHours * emp.HourlyRate * 1.5;

        double gross = regularPay + overtimePay;
        return gross;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Hours Worked: ");
        string hoursInput = Console.ReadLine();

        Console.Write("Enter Hourly Rate: ");
        string rateInput = Console.ReadLine();

        // Check that working hours are usable.
        if (!double.TryParse(hoursInput, out double hours) || hours < 0)
        {
            Console.WriteLine("Invalid hours worked entered. Must be a non-negative number.");
            return;
        }

        // Check that hourly rate is usable.
        if (!double.TryParse(rateInput, out double rate) || rate <= 0)
        {
            Console.WriteLine("Invalid hourly rate entered. Must be a positive number.");
            return;
        }

        // Reject hours that exceed the expected payroll range.
        if (hours > 744)
        {
            Console.WriteLine("Hours worked seems unrealistic. Please check the value.");
            return;
        }

        Employee emp = new Employee(name, hours, rate);
        PayrollCalculator payroll = new PayrollCalculator();

        double gross = payroll.CalculateGrossPay(emp);
        gross = Math.Round(gross, 2);

        Console.WriteLine();
        Console.WriteLine("Employee: " + emp.Name);
        Console.WriteLine("Gross Salary: " + gross);
    }
}
