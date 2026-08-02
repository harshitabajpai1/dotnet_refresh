using System;
using CSharpProgrammingChallenges;

Console.WriteLine("=== Q1: Swapping ===");
int x = 10, y = 20;
Console.WriteLine($"Before ref swap: x={x}, y={y}");
NumberSwapUtility.SwapWithRef(ref x, ref y);
Console.WriteLine($"After ref swap: x={x}, y={y}");
NumberSwapUtility.SwapWithOut(30, 40, out int p, out int q);
Console.WriteLine($"Out swap result: p={p}, q={q}");

Console.WriteLine("\n=== Q2: Multiplication Table ===");
int[] table = MultiplicationTableGenerator.GenerateMultiplicationRow(3, 5);
Console.WriteLine($"Table (3 x 5): [{string.Join(", ", table)}]");

Console.WriteLine("\n=== Q4: String Format ===");
string[] students = { "Alice:85", "Bob:60", "Charlie:90", "Dave:70" };
string json = StudentScoreFormatter.FilterAndSerialize(students, 70);
Console.WriteLine($"Filtered JSON: {json}");

Console.WriteLine("\n=== Q9: Arithmetic Expressions ===");
Console.WriteLine($"10 + 5 = {ArithmeticExpressionEvaluator.EvaluateExpression("10 + 5")}");
Console.WriteLine($"10 / 0 = {ArithmeticExpressionEvaluator.EvaluateExpression("10 / 0")}");
Console.WriteLine($"abc + 5 = {ArithmeticExpressionEvaluator.EvaluateExpression("abc + 5")}");

Console.WriteLine("\n=== Q10: Largest Integer ===");
Console.WriteLine($"Largest of 10, 30, 20 = {LargestIntegerFinder.FindLargestValue(10, 30, 20)}");

Console.WriteLine("\n=== Q13: Display Height ===");
Console.WriteLine($"140cm = {HeightCategoryClassifier.GetHeightCategory(140)}");
Console.WriteLine($"165cm = {HeightCategoryClassifier.GetHeightCategory(165)}");
Console.WriteLine($"185cm = {HeightCategoryClassifier.GetHeightCategory(185)}");

Console.WriteLine("\n=== Q16: Lucky Numbers ===");
Console.WriteLine($"Lucky numbers between 20-30 = {LuckyNumberCounter.CountLuckyNumbers(20, 30)}");

Console.WriteLine("\n=== Q19: Bank Transaction ===");
int finalBalance = BankTransactionCalculator.CalculateFinalBalance(1000, new int[] { 500, -200, -2000, 100 });
Console.WriteLine($"Final balance = {finalBalance}");

Console.WriteLine("\n=== Q22: Mahirl Alphabets ===");
Console.WriteLine($"Result = {MahirAlphabetProcessor.ProcessAlphabetPattern("programming", "morning")}");

Console.WriteLine("\n=== Q24: Merge Sorted Arrays ===");
int[] merged = SortedArrayMerger.MergeSortedArrays(new int[] { 1, 3, 5 }, new int[] { 2, 4, 6 });
Console.WriteLine($"Merged = [{string.Join(", ", merged)}]");

Console.WriteLine("\n=== Q27: Inventory Name Cleanup ===");
Console.WriteLine($"Cleaned = {InventoryNameCleaner.CleanProductName(" llapppptop bag ")}");

