using AuthenticationAndAuthorization.Models;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationAndAuthorization.Controllers
{
    public class ProductController : Controller
    {
        ProductRepo productRepo = null;
        public ProductController()
        {
            productRepo = new ProductRepo();
        }
        [Route("")]
        [Route("Cosmetics")]
        [Route("Product/Index1")]
        public IActionResult Index1()
        {
            return View(productRepo.GetAllCosmeticProducts());
        }
        public IActionResult Index2()
        {
            return View(productRepo.GetAllElectronicProducts());
        }
        public IActionResult Index3()
        {
            return View(productRepo.GetAllClothProduct());
        }
    }
}
