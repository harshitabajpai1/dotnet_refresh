using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;   //For ado.net classes

namespace ConArchDemo
{
    //DEMO CODE FOR CONNECTED ARCHITECTURE IN StudentDAL CLASS
    internal class StudentDAL
    {

        SqlConnection con = null; //for connection
        SqlCommand cmd = null;
        SqlDataReader sdr = null;

        public StudentDAL()
        {
            string conStr = "Data Source=.\\sqlexpress;Inital Catalog=LPU_DB;Integrated Security=True";
            con = new SqlConnection();
            con.ConnectionString = "Server=.\\Sqlexpress;Integrated Security=SSPI;Database=LPU_DB;TrustServerCertificate=true";
        }
        public List<Student> ShowAllStudents()
        {
            List<Student> studList = new List<Student>();

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "Select * from StudentInfo";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;


                //holding data via reader

                sdr = cmd.ExecuteReader();
                //while (sdr.Read())
                //{//we should not write console.writeline in DAL layer
                //    Console.WriteLine(sdr.GetString(0));

                //}

                DataTable myDT = new DataTable();
                myDT.Load(sdr);

                //Convert table into List
                foreach (DataRow dr in myDT.Rows) {
                    Student sObj = new Student()
                    {
                        RollNo = Convert.ToInt32(dr[0].ToString()),
                        Name = dr[1].ToString(),
                        Address = dr[3].ToString()
                    };
                    if (sObj != null)
                    {
                        studList.Add(sObj);
                    }
                }
            }
            catch (SqlException e)
            {
                //catch the exception in UI Layer
                throw e;
            }
            finally
            {
                con.Close();
            }
            
            return studList;

        }
        public List<Student> SearchByName(string name)
        {
            List<Student> studList = null;

            return studList;

        }

        public Student SearchByRollNo(int rollNo)
        {
            Student stud = null;
            return stud;
        }
    }
}
