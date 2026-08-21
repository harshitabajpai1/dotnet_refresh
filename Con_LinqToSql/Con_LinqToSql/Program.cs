using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_LinqToSql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LpuDbClassesDataContext dbCon = new LpuDbClassesDataContext();
            Products1 p1 = new Products1
            {
                ProdId = 109,
                Name ="tuppperware flask",
                Price =100,
                Desc = "virgin plastic for water",
            };

            dbCon.Products1s.InsertOnSubmit(p1);
            dbCon.SubmitChanges();
            Console.WriteLine("Product added successfully!");
        }
    }
}
