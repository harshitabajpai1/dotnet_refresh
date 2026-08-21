using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolAttendanceMangement.Model;

namespace SchoolAttendanceMangement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<StudentAttendanceDetails> Get()
        {
            var obj1 = new StudentAttendanceDetails { StudentID = 1, StudentName = "Harshita", AttendacePercentage = 94.0 };
            var obj2 = new StudentAttendanceDetails { StudentID = 2, StudentName = "Shivansh", AttendacePercentage = 92.0 };
            return new List<StudentAttendanceDetails> { obj1, obj2 };
        }
    }
}
