using System;
using System.Data.SqlClient;

public class StudentUtility
{
    private string connectionString =
        "Server=.\\sqlexpress;Database=StudentDB;Integrated Security=true;TrustServerCertificate=true;";

    // INSERT
    public void InsertStudent(string name, int age, string course)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Students (Name, Age, Course) VALUES (@Name,@Age,@Course)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Age", age);
            cmd.Parameters.AddWithValue("@Course", course);

            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Student Inserted Successfully!");
        }
    }

    // READ
    public void ViewStudents()
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Students";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\nID\tName\tAge\tCourse");

            while (reader.Read())
            {
                Console.WriteLine($"{reader["Id"]}\t{reader["Name"]}\t{reader["Age"]}\t{reader["Course"]}");
            }
        }
    }

    // UPDATE
    public void UpdateStudent(int id, string name, int age, string course)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "UPDATE Students SET Name=@Name, Age=@Age, Course=@Course WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Age", age);
            cmd.Parameters.AddWithValue("@Course", course);

            con.Open();
            int rows = cmd.ExecuteNonQuery();

            Console.WriteLine(rows > 0 ? "Student Updated!" : "Student Not Found!");
        }
    }

    // DELETE
    public void DeleteStudent(int id)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "DELETE FROM Students WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            int rows = cmd.ExecuteNonQuery();

            Console.WriteLine(rows > 0 ? "Student Deleted!" : "Student Not Found!");
        }
    }
}