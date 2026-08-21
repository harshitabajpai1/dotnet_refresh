using System.ComponentModel.DataAnnotations;
namespace MVC_Core_WebApp1.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Roll number cannot be left blank")] //built in attributes for validation
        public int RollNo { get; set; }

        [Required(ErrorMessage = "Name number cannot be left blank")]
        [StringLength(15,MinimumLength = 2,ErrorMessage ="Name minimum length is 2 character and max length is 15")]
        public string Name { get; set; }
        public string Address { get; set; }

        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60")] //built in attributes for validation
        public int Age { get; set; }
    }
}
