using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDisconnectedArchDemo
{
    public partial class Form1 : Form
    {
        BindingContext bindObj = null;
        DataTable myDt = null;

        SqlCommandBuilder bilder = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

            ProductUtility prodObj = new ProductUtility();
            //we can also create the object of IRepo<Product> interface and assign the object of ProductUtility class to it as it implements the IRepo<Product> interface
            dataGridView1.DataSource = prodObj.ShowAllData();


             myDt = prodObj.GetAllData();

            //binding UI Elements with Table columns

            txtProductId.DataBindings.Add("Text",myDt, myDt.Columns[0].ColumnName);

            //Column[0].ColumnName will return the name of the first column in the table and that will be used to bind with the Text property of txtProductId TextBox
            //columnName will return the name of the column in the table and that will be used to bind with the Text property of txtProductId TextBox
             txtProductName.DataBindings.Add("Text", myDt, myDt.Columns[1].ColumnName);
             txtPrice.DataBindings.Add("Text", myDt, myDt.Columns[2].ColumnName);
             txtDescription.DataBindings.Add("Text", myDt, myDt.Columns[3].ColumnName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BindingContext[myDt].Position = 0; //move to the first record
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BindingContext[myDt].Position = this.BindingContext[myDt].Count - 1; //move to the last record
        }

        private void button2_Click(object sender, EventArgs e)
        {//to move to previous record
            if (this.BindingContext[myDt].Position > 0)
            {
                this.BindingContext[myDt].Position -= 1;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //to move to next record
            if (this.BindingContext[myDt].Position < this.BindingContext[myDt].Count)
            {
                this.BindingContext[myDt].Position += 1;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
