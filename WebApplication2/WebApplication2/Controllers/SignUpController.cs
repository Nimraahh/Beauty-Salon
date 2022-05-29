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
            bool ans = d.AddUser(u);
            //if (ModelState.IsValid)
            //{
                if (ans == true)
                {
                    return View("Views/Home/Index.cshtml");
                }
                else
                {
                    return View("Views/SignUp/supfailed.cshtml");
                   // return View();
                }
            //}
            //else
            //{
            //   // ModelState.AddModelError(string.Empty, "Invalid Credentials");
            //    return View();
            //}



        }
    }
}
