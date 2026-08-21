using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDisconnectedArchDemo
{
    //Specific interfacce for product related operations
    public interface IProductRepo : IRepo<Product>
    {
        List<Product> ShowAllProductByCategory(int  categoryId);
        List<Product> ShowAllProductByPriceAsc();
        List<Product> ShowAllProductByPriceDesc();
        List<Product> GetTop3CostlyProduct();
        List<Product> GetTop3BudgetProduct();

    }
}
