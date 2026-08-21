using System;

class Program
{
    static void Main()
    {
        StudentUtility utility = new StudentUtility();

        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. View");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Course: ");
                    string course = Console.ReadLine();
                    utility.InsertStudent(name, age, course);
                    break;

                case 2:
                    utility.ViewStudents();
                    break;

                case 3:
                    Console.Write("ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("New Name: ");
                    string newName = Console.ReadLine();
                    Console.Write("New Age: ");
                    int newAge = Convert.ToInt32(Console.ReadLine());
                    Console.Write("New Course: ");
                    string newCourse = Console.ReadLine();
                    utility.UpdateStudent(id, newName, newAge, newCourse);
                    break;

                case 4:
                    Console.Write("ID: ");
                    int deleteId = Convert.ToInt32(Console.ReadLine());
                    utility.DeleteStudent(deleteId);
                    break;

                case 5:
                    return;
            }
        }
    }
}