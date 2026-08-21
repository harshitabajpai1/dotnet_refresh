using Microsoft.AspNetCore.Mvc;

namespace MVC_Core_WebApp1.Controllers
{
    public class DummyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult CallError()
        {
            throw new Exception("This is a dummy exception for testing error handling.");
        }
        public ActionResult DoDivision(int num1, int num2)
        {
            float result = 0;
            try
            {
                result = num1 / num2;
            }
            catch(DivideByZeroException ex)
            {
                throw ex;
            }
            finally
            {
                ViewBag.Message = result;
            }
            return View();
        }
    }
}
