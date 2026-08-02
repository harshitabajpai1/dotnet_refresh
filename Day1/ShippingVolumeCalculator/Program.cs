using System;

class ShippingVolumeApplication
{
    static void Main()
    {
        Console.Write("Enter Length: ");
        string lengthInput = Console.ReadLine();

        Console.Write("Enter Width: ");
        string widthInput = Console.ReadLine();

        Console.Write("Enter Height: ");
        string heightInput = Console.ReadLine();

        // Validate length.
        if (!double.TryParse(lengthInput, out double length) || length <= 0)
        {
            Console.WriteLine("Invalid length. Length must be a positive number.");
            return;
        }

        // Validate width.
        if (!double.TryParse(widthInput, out double width) || width <= 0)
        {
            Console.WriteLine("Invalid width. Width must be a positive number.");
            return;
        }

        // Validate height.
        if (!double.TryParse(heightInput, out double height) || height <= 0)
        {
            Console.WriteLine("Invalid height. Height must be a positive number.");
            return;
        }

        double volume = length * width * height;
        volume = Math.Round(volume, 2);

        Console.WriteLine();
        Console.WriteLine("Calculated Volume: " + volume);
    }
}
