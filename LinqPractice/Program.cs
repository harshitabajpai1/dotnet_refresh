using System;
using System.Collections.Generic;

namespace EmployeeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeUtility utility = new EmployeeUtility();

    
            Console.WriteLine("********************All Employees*****************");
            var all = utility.GetAllEmployees();
            foreach (var emp in all)
            {
                Console.WriteLine("ID: "+emp.EmployeeID);
                Console.WriteLine("First Name: "+emp.FirstName);
                Console.WriteLine("Last Name: "+emp.LastName);
                Console.WriteLine("Title: "+emp.Title);
                Console.WriteLine("City: "+emp.City);
                Console.WriteLine("DOJ: "+emp.DOJ.ToString());
                Console.WriteLine("--------------------------------------------------");
            }
            Console.WriteLine("************************************************************");

        
            Console.WriteLine("*****************8Employees Not in Mumbai***********88");
            var notMumbai = utility.GetEmployeesNotInMumbai();
            foreach (var emp in notMumbai)
            {
                Console.WriteLine("ID: "+emp.EmployeeID);
                Console.WriteLine("First Name: "+emp.FirstName);
                Console.WriteLine("Last Name: "+emp.LastName);
                Console.WriteLine("Title: "+emp.Title);
                Console.WriteLine("City: "+emp.City);
                Console.WriteLine("DOJ: "+emp.DOJ.ToString());
                Console.WriteLine("--------------------------------------------------");
            }
            Console.WriteLine("************************************************************");

            Console.WriteLine("***********Employees- AsstManager***********8");
            var asst = utility.GetAsstManagers();
            foreach (var emp in asst)
            {
                Console.WriteLine("ID: "+emp.EmployeeID);
                Console.WriteLine("First Name: "+emp.FirstName);
                Console.WriteLine("Last Name: "+emp.LastName);
                Console.WriteLine("Title: "+emp.Title);
                Console.WriteLine("City: "+emp.City);
                Console.WriteLine("DOJ: "+emp.DOJ.ToString());
                Console.WriteLine("--------------------------------------------------");
            }
            Console.WriteLine("************************************************************");

            Console.WriteLine(" ***********Employees whose Last Name starts with S**************8");
            var lastNameS = utility.GetLastNameStartsWithS();
            foreach (var emp in lastNameS)
            {
                Console.WriteLine("ID: "+emp.EmployeeID);
                Console.WriteLine("First Name: "+emp.FirstName);
                Console.WriteLine("Last Name: "+emp.LastName);
                Console.WriteLine("Title: "+emp.Title);
                Console.WriteLine("City: "+emp.City);
                Console.WriteLine("DOJ: "+emp.DOJ.ToString());
                Console.WriteLine("--------------------------------------------------");
            }
            Console.WriteLine("************************************************************");

            
            Console.WriteLine("*********Employees Joined Before 01/01/2015************88");
            var joined = utility.GetJoinedBefore2015();
            foreach (var emp in joined)
            {
                Console.WriteLine("ID: "+emp.EmployeeID);
                Console.WriteLine("First Name: "+emp.FirstName);
                Console.WriteLine("Last Name: "+emp.LastName);
                Console.WriteLine("Title: "+emp.Title);
                Console.WriteLine("City: "+emp.City);
                Console.WriteLine("DOJ: "+emp.DOJ.ToString());
                Console.WriteLine("--------------------------------------------------");
            }
            Console.WriteLine("************************************************************");

        }
    }
}