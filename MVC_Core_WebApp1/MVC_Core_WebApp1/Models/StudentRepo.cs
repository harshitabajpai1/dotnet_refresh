namespace MVC_Core_WebApp1.Models
{
    public class StudentRepo : IRepo<Student>
    {
        public static List<Student> studentList = null;
        //http is a stateless protocol, so we need to make the list static to maintain the data across different requests.

        public StudentRepo()
        {
            if(studentList == null)
            {
                //collection initilizer
                //syntax to create a new list of Student objects and populate it with some initial data. This is just for demonstration purposes, and in a real application, you would typically retrieve this data from a database or another data source.
                studentList = new List<Student>()
                {
                    //object initializer
                    new Student(){RollNo=1,Name="John Doe",Address="123 Main St",Age=20},
                    new Student(){RollNo=2,Name="Jane Smith",Address="456 Elm St",Age=22 },
                    new Student(){RollNo=3,Name="Bob Johnson",Address="789 Oak St",Age=19 },
                    new Student(){RollNo=4,Name="Alice Brown",Address="321 Pine St",Age=21 },

                };
            }
        }
        public bool AddData(Student obj)
        {
            //throw new NotImplementedException();
            bool flag = false;
            if(obj != null)
            {
                studentList.Add(obj);
                flag = true;
            }
            else
            {
                throw new NullReferenceException("Object cannot be null");
            }
            return flag;

        }

        public bool DeleteData(int id)
        {
            //throw new NotImplementedException();
            bool flag = false;
            Student sObj = studentList.Where(s => s.RollNo == id).FirstOrDefault();
            if(sObj != null)
            {
                studentList.Remove(sObj);
                flag = true;
            }
            else
            {
                throw new NullReferenceException("Object not found with the given id");
            }
            return flag;

        }

        public List<Student> ShowAllData()
        {
            //throw new NotImplementedException();
            return studentList;

            
        }

        public Student ShowDetailsById(int id)
        {
            //throw new NotImplementedException();
            Student sObj = studentList.Find(s => s.RollNo == id);
            //if we use where it will return IEnumerable<Student> and we need to use first or default to get the single object.
            //but if we use find it will return the single object directly.
            return sObj;
        }

        public bool UpdateData(int id, Student obj)
        {
            //throw new NotImplementedException();
            bool flag = false;
            Student sObj = studentList.Find(s => s.RollNo == id);
            if(sObj != null) 
            {
                sObj.Name = obj.Name;
                sObj.Address = obj.Address;
                sObj.Age = obj.Age;
                flag = true;
            }
            else
            {
                throw new NullReferenceException("Object not found with the given id");


            }
                return flag;
        }
    }
}
