<<<<<<< HEAD
﻿// See https://aka.ms/new-console-template for more information
using InterfaceDemo;
Console.WriteLine("Demo on interface");


// MathClass m1 = new MathClass();  //alot - Add

// MathClass m2 = new MathClass();  //Riya - add/sub

// MathClass m3 = new MathClass();  //rajat-add/sub/prod/div

// IAdd m1 = new MathClass();  //alot - Add

// IAddSub m2 = new MathClass();  //Riya - add/sub

// IAll m3 = new MathClass();  //rajat-add/sub/prod/div

// // m1.SubMe(5,8);  ----> will not work
// m1.AddMe(6,7);

//Approach 1
Product pObj = new Product();
pObj.ProID=101;
pObj.Name = "flask";
pObj.Price = 870;

//approach 2
//object initializer
Product pObj1 = new Product(){ProID=102, Name = "marker", Price = 60};


//approach 3
//collection initializer
List<Product> prodList = new List<Product>()
{
    new Product(){ProID=102, Name = "marker", Price = 60},
    new Product(){ProID=103, Name = "pen", Price = 20},
    new Product(){ProID=104, Name = "mop", Price = 600},
    new Product(){ProID=105, Name = "pencil", Price = 5},
    
};

foreach (var item in prodList)
{
    Console.WriteLine($"{item.ProID}\t{item.Name}\t{item.Price}");
=======
﻿// See https://aka.ms/new-console-template for more information
using InterfaceDemo;
Console.WriteLine("Demo on interface");


// MathClass m1 = new MathClass();  //alot - Add

// MathClass m2 = new MathClass();  //Riya - add/sub

// MathClass m3 = new MathClass();  //rajat-add/sub/prod/div

// IAdd m1 = new MathClass();  //alot - Add

// IAddSub m2 = new MathClass();  //Riya - add/sub

// IAll m3 = new MathClass();  //rajat-add/sub/prod/div

// // m1.SubMe(5,8);  ----> will not work
// m1.AddMe(6,7);

//Approach 1
Product pObj = new Product();
pObj.ProID=101;
pObj.Name = "flask";
pObj.Price = 870;

//approach 2
//object initializer
Product pObj1 = new Product(){ProID=102, Name = "marker", Price = 60};


//approach 3
//collection initializer
List<Product> prodList = new List<Product>()
{
    new Product(){ProID=102, Name = "marker", Price = 60},
    new Product(){ProID=103, Name = "pen", Price = 20},
    new Product(){ProID=104, Name = "mop", Price = 600},
    new Product(){ProID=105, Name = "pencil", Price = 5},
    
};

foreach (var item in prodList)
{
    Console.WriteLine($"{item.ProID}\t{item.Name}\t{item.Price}");
>>>>>>> 439b82da24516ed3627b2960bcaf1c7c27e74f89
}