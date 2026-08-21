using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDisconnectedArchDemo
{
    /// <summary>
    /// Entity class for Product. It will have properties like Id, Name, Price, etc. 
    /// and will be used to transfer data between layers.
    /// </summary>
    public class Product
    {
        #region Fields

        int productId;
        string productName;
        float price;
        string description;

        #endregion

        #region Properties

        public int ProductId
        {
            get { return productId; }
            set
            {
                if (value <= 0 || value >= 999)
                {
                    throw new MyCustomException("Invalid Product Id");
                }
                else
                {
                    productId = value;
                }

            }

        }
        public string ProductName { get; set; }
        public float Price { get; set; } 
        public string Description { get; set; }
        #endregion


    }
}
