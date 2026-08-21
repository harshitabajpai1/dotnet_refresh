using FirstWebApiDemo.Models;
using FirstWebApiDemo.Models.Repos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        StudentRepos studentRepo = null;
        public StudentsController()
        {
            studentRepo = new StudentRepos();
            
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return studentRepo.GetAll();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return studentRepo.Get(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, Student obj)
        {
            bool result = studentRepo.Update(id, obj);
            if (result)
            {
                Response.StatusCode = 200;
                Response.WriteAsync("The student is updated");
            }
            else
            {
                Response.StatusCode = 404;
                Response.WriteAsync("The student is not found on the id");
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            bool result = studentRepo.Delete(id);
            if (result)
            {
                //return Ok("Student deleted successfully");
                Response.StatusCode = 200;
                Response.WriteAsync("Student deleted successfully");

            }
            else
            {
                //return NotFound("Student not found with the given id");
                Response.StatusCode = 404;
                Response.WriteAsync("Student not found with the given id");
            }
        }
    }
}
