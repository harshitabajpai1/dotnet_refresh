using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WinDisconnectedArchDemo
{
    internal class ProductUtility : IProductRepo
    {
        IDbConnection con;
        SqlDataAdapter adapter1;
        DataSet ds; //copy of database in memory
        //dataset is the client side copy of database in memory and it is disconnected from database and it is used to perform crud operations on data in memory and then we can update the database with the changes made in dataset
        //logical copy of the database in memory and it is used to perform crud operations on data in memory and then we can update the database with the changes made in dataset

        //the command builder is used to automatically generate the insert, update and delete commands for the data adapter based on the select command and the schema of the dataset
        //the command builder works with the data adapter and data adapter must work with the primary key of the table.


        SqlCommandBuilder bilder = null;

        public ProductUtility()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=.\\sqlexpress;Integrated Security=true;Database=LPU_Db;TrustServerCertificate=true";
        }
        public bool AddData(Product obj)
        {
            throw new NotImplementedException();
        }

        public bool DeleteData(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetTop3BudgetProduct()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetTop3CostlyProduct()
        {
            throw new NotImplementedException();
        }

        public Product SearchById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Product> ShowAllData()
        {
            //throw new NotImplementedException();

            List<Product> list = null;

            adapter1 = new SqlDataAdapter("select * from Products1",(SqlConnection) con); 
            adapter1.MissingSchemaAction = MissingSchemaAction.AddWithKey; 
            //to add primary key in dataset ds = new DatTaSet(); adapter1.Fill(ds, "Products1"); List<Product> list = new List<Product>(); foreach (DataRow dr in ds.Tables["Products1"].Rows) { Product p = new Product(); p.ProductId = Convert.ToInt32(dr["ProductId"]); p.ProductName = dr["ProductName"].ToString(); p.Price = Convert.ToInt32(dr["Price"]); p.Description = dr["Description"].ToString(); list.Add(p); } return list;

            ds = new DataSet();
            adapter1.Fill(ds, "Prod");
            if (ds.Tables[0].Rows.Count > 0)
            {
                list= new List<Product>();
                foreach(DataRow dRow in ds.Tables["Prod"].Rows)
                {
                    Product p1 = new Product() {
                        ProductId = Int32.Parse(dRow[0].ToString()),
                        ProductName = dRow[1].ToString(),
                        Price = Single.Parse(dRow[2].ToString()),
                        Description = dRow[3].ToString()
                    };
                    list.Add(p1);
                }

            }
            return list;
        }

        public List<Product> ShowAllProductByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Product> ShowAllProductByPriceAsc()
        {
            throw new NotImplementedException();
        }

        public List<Product> ShowAllProductByPriceDesc()
        {
            throw new NotImplementedException();
        }

        public bool UpdateData(int Id, Product obj)
        {
            SqlCommand updateCmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@productId", obj.ProductId);
            param[1] = new SqlParameter("@productName", obj.ProductName);
            param[2] = new SqlParameter("@price", obj.Price);
            param[3] = new SqlParameter("@description", obj.Description);

            updateCmd.CommandText = "Update Product set ProductName=@productName,Price=@price,Description = @description where ProductId = @productId";
            updateCmd.Connection = (SqlConnection)con;
            updateCmd.CommandType = CommandType.Text;

            updateCmd.Parameters.AddRange(param);

            adapter1.UpdateCommand = updateCmd;

            bilder.DataAdapter = adapter1;
            //bilder.GetUpdateCommand(); //to get the update command for the data adapter based on the select command and the schema of the dataset
            
            adapter1.Update(ds); //to update the database with the changes made in dataset

            return true;
        }

        public DataTable GetAllData()
        {
            adapter1 = new SqlDataAdapter("select * from Products1", (SqlConnection)con);
            adapter1.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            //to add primary key in dataset ds = new DatTaSet(); adapter1.Fill(ds, "Products1"); List<Product> list = new List<Product>(); foreach (DataRow dr in ds.Tables["Products1"].Rows) { Product p = new Product(); p.ProductId = Convert.ToInt32(dr["ProductId"]); p.ProductName = dr["ProductName"].ToString(); p.Price = Convert.ToInt32(dr["Price"]); p.Description = dr["Description"].ToString(); list.Add(p); } return list;

            bilder = new SqlCommandBuilder(adapter1); //to automatically generate the insert, update and delete commands for the data adapter based on the select command and the schema of the dataset

            ds = new DataSet();
            adapter1.Fill(ds, "Prod");

            return ds.Tables[0];
        }

    }
}
