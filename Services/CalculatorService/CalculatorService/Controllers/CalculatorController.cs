using CalculatorService.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorService.Controllers
{
    public class CalculatorController : Controller
    {
        AddServices addServices = new AddServices();
        MultiplyServices multiplyServices = new MultiplyServices();
        public ActionResult Add(int a , int b)
        {
            int result = addServices.Add(a, b);
            ViewBag.Result = result;
            return View();
        }
        public ActionResult Multiply(int a , int b)
        {
             int result = multiplyServices.Multiply(a, b);
             ViewBag.Result = result;
             return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
