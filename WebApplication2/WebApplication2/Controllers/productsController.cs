using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class productsController : Controller
    {
        public IActionResult products()
        {
            return View();
        }
        public IActionResult p1()
        {
            return View();
        }
    }
}
