using System;

class BodyMassIndexApplication
{
    static void Main()
    {
        Console.Write("Enter Weight (kg): ");
        string weightInput = Console.ReadLine();

        Console.Write("Enter Height (m): ");
        string heightInput = Console.ReadLine();

        // Validate the weight input.
        if (!double.TryParse(weightInput, out double weight) || weight <= 0)
        {
            Console.WriteLine("Invalid weight entered. Weight must be a positive number.");
            return;
        }

        // Validate height so BMI division stays safe.
        if (!double.TryParse(heightInput, out double height) || height <= 0)
        {
            Console.WriteLine("Invalid height entered. Height must be a positive number.");
            return;
        }

        double bmi = weight / (height * height);
        bmi = Math.Round(bmi, 2);

        string category;

        // Classify the BMI value.
        if (bmi < 18.5)
        {
            category = "Underweight";
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            category = "Normal";
        }
        else if (bmi >= 25 && bmi <= 29.9)
        {
            category = "Overweight";
        }
        else
        {
            category = "Obese";
        }

        Console.WriteLine();
        Console.WriteLine("Your BMI is: " + bmi);
        Console.WriteLine("Category: " + category);
    }
}
