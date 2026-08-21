using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConArchDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentDAL dal = new StudentDAL();
           foreach(var item in dal.ShowAllStudents())
            {
                Console.WriteLine($"{item.RollNo}\t{item.Name}");
            }
        }
    }
}
