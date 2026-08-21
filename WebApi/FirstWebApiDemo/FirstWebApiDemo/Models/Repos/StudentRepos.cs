namespace FirstWebApiDemo.Models.Repos
{
    public class StudentRepos : IRepos<Student>
    {
        public static List<Student> studList = null;
        public StudentRepos()
        {
            if(studList == null)
            {
                studList = new List<Student>()
                {
                    new Student(){RollNo =101, Name ="Alok", City ="Jandhar",PhoneNo ="1234567890"},
                    new Student(){RollNo =102, Name ="Amit", City ="Delhi",PhoneNo ="0987654321"},
                    new Student(){RollNo =103, Name ="Riya", City ="Mumbai",PhoneNo ="2345678901"},

                };
            }
            
        }
        public bool Add(Student obj)
        {
            bool flag = false;
            if(obj!=null)
            {
                studList.Add(obj);
                flag = true;

            }
            return flag;
            
            
        }

        public bool Delete(int id)
        {
            bool flag = false;
            //throw new NotImplementedException();
            Student stud = studList.Find(s => s.RollNo == id);
            if (stud != null) { 
                studList.Remove(stud);
                flag = true;
            }
            return flag;
        }

        public Student Get(int id)
        {
            Student stud = studList.Find(s => s.RollNo == id); //will return the student with the first match of the id
            //if we use FirstOrDefault() instead of Find() then it will return null if no match is found, otherwise it will return the first match
            //firstordefault() is a LINQ method and it is used to return the first element of a sequence that satisfies a specified condition or a default value if no such element is found.
            //firstordefault return ienumberable and find return the object directly

            if(stud!=null)
            {
                return stud;
            }
            else
            {
                throw new Exception("Student not found with the given id");
            }

        }

        public ICollection<Student> GetAll()
        {
            //throw new NotImplementedException();
            return studList;
        }

        public bool Update(int id, Student obj)
        {
            //throw new NotImplementedException();
            bool flag = false;
            Student student = studList.Find(s => s.RollNo == id);
            if(student!=null && obj != null)
            {
                student.Name = obj.Name;
                student.City = obj.City;
                student.PhoneNo = obj.PhoneNo;
                flag = true;
            }
            return flag;
        }
    }
}
