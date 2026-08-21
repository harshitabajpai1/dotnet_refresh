using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolAdmissionManagement.Model;

namespace SchoolAdmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<StudentAdmissionDetails> Get()
        {
            var obj1 = new StudentAdmissionDetails { StudentID = 1, StudentName = "Harshita", StudentClass = "X", DateOfJoining = DateTime.Now };
            var obj2 = new StudentAdmissionDetails { StudentID = 2, StudentName = "Shivansh", StudentClass = "IX", DateOfJoining = DateTime.Now };

            return new List<StudentAdmissionDetails> { obj1, obj2 };
        }
    }
}
