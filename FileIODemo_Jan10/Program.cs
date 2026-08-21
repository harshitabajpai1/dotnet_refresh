// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


DirectoryDemo dObj =new DirectoryDemo();
// dObj.DirectoryDemoFunc("LPU");

// dObj.DriveInfoFunc("C:\\LPU");


FileStreamDemo fsDemoObj = new FileStreamDemo();
// fsDemoObj.CreateFile(@"C:\dotnet\FileIODemo_Jan10\sample.txt");
fsDemoObj.ReadFile(@"C:\dotnet\FileIODemo_Jan10\sample.txt");