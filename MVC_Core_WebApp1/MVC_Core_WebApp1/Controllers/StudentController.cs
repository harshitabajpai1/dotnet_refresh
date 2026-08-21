using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Core_WebApp1.Models;

namespace MVC_Core_WebApp1.Controllers
{
    public class StudentController : Controller
    {
        StudentRepo studentRepo = null;
        public StudentController()
        {
            studentRepo = new StudentRepo();
        }
        [HttpGet]
        public string[] GetAllCities()
        {
            return new string[] { "Mumbai", "Pune", "Delhi", "Bangalore" };
        }
        // GET: StudentController
        public ActionResult Index()
        {
            List<Student> studentList = studentRepo.ShowAllData();
            return View(studentList);
        }

        // GET: StudentController/Details/5
        [Route("StudentInfo/")]
        public ActionResult Details(int id)
        {
            Student s = studentRepo.ShowDetailsById(id);
            return View(s);
        }
        public ActionResult Details1(int rollNo)
        {
            Student s = studentRepo.ShowDetailsById(rollNo);
            return View(s);
        }

        //GET :student controll to search by name

        public ActionResult StudentDetailsByName(string name)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student s1)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    studentRepo.AddData(s1);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //show dummy function
            public ActionResult ShowDummy(int id)
            {
            Student s = studentRepo.ShowDetailsById(id);
            if(s == null)
            {
                return NotFound();
            }
            //string message = "Hello everyone";
            return View("ShowDummy",s.Name);
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
