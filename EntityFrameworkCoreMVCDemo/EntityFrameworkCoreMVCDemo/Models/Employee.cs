using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCoreMVCDemo.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int DeptId { get; set; }

        // Navigation property to establish the relationship with Department
        //public virtual Department Department { get; set; }
    }
}
