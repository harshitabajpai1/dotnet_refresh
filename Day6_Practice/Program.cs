// See https://aka.ms/new-console-template for more information
Console.WriteLine("Practice Questions");

//    QUESTION 1
// Console.Write("enter radius: ");
// double radius = Double.Parse(Console.ReadLine());
// AreaOfCircle circle = new AreaOfCircle(radius);
// double area = circle.Area(radius);
// Console.WriteLine("Area: "+area);

//    QUESTION 2
// Console.Write("enter feet to convert to centimeter: ");
// int feet = Int32.Parse(Console.ReadLine());
// FeetToCenti feetObj = new FeetToCenti(feet);
// double centi = feetObj.FeetToCentimeter(feet);
// Console.WriteLine("Feet to centimeter: "+centi);


// QUESTION 3
// Console.Write("Enter the height: ");
// int heightCm = Int32.Parse(Console.ReadLine());
// HeightCategory heightObj = new HeightCategory(heightCm);
// string category = heightObj.Category(heightCm);
// Console.WriteLine("Height category: "+category);



//    QUESTION 4
// Console.Write("Enter first number: ");
// int a = int.Parse(Console.ReadLine());

// Console.Write("Enter second number: ");
// int b = int.Parse(Console.ReadLine());

// Console.Write("Enter third number: ");
// int c = int.Parse(Console.ReadLine());

// LargestOfThree obj4 = new LargestOfThree();
// Console.WriteLine("Largest number: " + obj4.FindLargest(a, b, c));


// /QUESTION 5
// Console.Write("Enter total seconds: ");
// int totalSeconds = int.Parse(Console.ReadLine());

// TimeFormatter obj5 = new TimeFormatter();
// Console.WriteLine("Formatted time: " + obj5.FormatSeconds(totalSeconds));


// /  QUESTION 6
// Console.Write("Enter array size: ");
// int size = int.Parse(Console.ReadLine());

// int[] nums = new int[size];
// Console.WriteLine("Enter elements:");

// for (int i = 0; i < size; i++)
// {
//     nums[i] = int.Parse(Console.ReadLine());
// }

// PositiveSum obj6 = new PositiveSum();
// Console.WriteLine("Sum of positives until zero: " + obj6.SumUntilZero(nums));



//   QUESTION 7
// Console.Write("Enter number: ");
// int n = int.Parse(Console.ReadLine());

// Console.Write("Enter upto: ");
// int upto = int.Parse(Console.ReadLine());

// MultiplicationTable obj7 = new MultiplicationTable();
// int[] table = obj7.GetRow(n, upto);

// Console.WriteLine("Multiplication row:");
// foreach (int val in table)
// {
//     Console.Write(val + " ");
// }
// Console.WriteLine();




//   QUESTION 8 
// Console.Write("Enter number of strings: ");
// int count = int.Parse(Console.ReadLine());

// string[] tokens = new string[count];
// Console.WriteLine("Enter strings:");

// for (int i = 0; i < count; i++)
// {
//     tokens[i] = Console.ReadLine();
// }

// ParseAndSum obj8 = new ParseAndSum();
// Console.WriteLine("Sum of valid integers: " + obj8.SumValidIntegers(tokens));


//   QUESTION 9
// Console.Write("Enter first number: ");
// int x = int.Parse(Console.ReadLine());

// Console.Write("Enter second number: ");
// int y = int.Parse(Console.ReadLine());

// GCDCalculator obj9 = new GCDCalculator();
// Console.WriteLine("GCD: " + obj9.GCD(x, y));


// /  QUESTION 10
// Console.Write("Enter initial balance: ");
// int initialBalance = int.Parse(Console.ReadLine());

// Console.Write("Enter number of transactions: ");
// int tCount = int.Parse(Console.ReadLine());

// int[] transactions = new int[tCount];
// Console.WriteLine("Enter transactions:");

// for (int i = 0; i < tCount; i++)
// {
//     transactions[i] = int.Parse(Console.ReadLine());
// }

// BankAccount obj10 = new BankAccount();
// Console.WriteLine("Final Balance: " +
//     obj10.GetFinalBalance(initialBalance, transactions));



//   Question 11
// Console.Write("Enter number of values: ");
// int objCount = int.Parse(Console.ReadLine());

// object[] values = new object[objCount];
// Console.WriteLine("Enter values (int/string/bool):");

// for (int i = 0; i < objCount; i++)
// {
//     string input = Console.ReadLine();

//     if (int.TryParse(input, out int iv))
//         values[i] = iv;
//     else if (bool.TryParse(input, out bool bv))
//         values[i] = bv;
//     else
//         values[i] = input;
// }

// IntegerSumFromObjects obj11 = new IntegerSumFromObjects();
// Console.WriteLine("Sum of integers: " + obj11.SumIntegers(values));



 //   QUESTION 12
// Console.Write("Enter array size: ");
// int size12 = int.Parse(Console.ReadLine());

// int[] arr12 = new int[size12];
// Console.WriteLine("Enter numbers:");

// for (int i = 0; i < size12; i++)
// {
//     arr12[i] = int.Parse(Console.ReadLine());
// }

// ArraySummary obj12 = new ArraySummary();
// Console.WriteLine(obj12.GetSummary(arr12));


///   QUESTION 15

// Console.Write("Enter number of shapes: ");
// int shapeCount = int.Parse(Console.ReadLine());

// double totalArea = 0;

// for (int i = 0; i < shapeCount; i++)
// {
//     string[] parts = Console.ReadLine().Split(' ');
//     Shape shape = null;

//     if (parts[0] == "C")
//         shape = new Circle(double.Parse(parts[1]));
//     else if (parts[0] == "R")
//         shape = new Rectangle(double.Parse(parts[1]), double.Parse(parts[2]));
//     else if (parts[0] == "T")
//         shape = new Triangle(double.Parse(parts[1]), double.Parse(parts[2]));

//     totalArea += shape.Area();
// }

// Console.WriteLine("Total Area: " +
//     Math.Round(totalArea, 2, MidpointRounding.AwayFromZero));