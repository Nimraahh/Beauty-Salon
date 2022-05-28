using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class SignUpController : Controller
    {
        [HttpGet]
        public ViewResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ViewResult SignUp(user u)
        {
            data d = new data();
            //if (ModelState.IsValid)
            //{
                if (d.AddUser(u) == true)
                {
                    return View("Views/Home/Index.cshtml");
                }
                else
                {
                    return View("supfailed");
                }
            //}
            //else
            //{
            //    ModelState.AddModelError(string.Empty, "Invalid Credentials");
            //    return View("supfailed");
            //}
            
            
           
        }
    }
}
