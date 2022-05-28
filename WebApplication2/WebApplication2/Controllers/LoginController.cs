using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Login(user u)
        {
            data d = new data();
            //if(ModelState.IsValid)
            //{
                if(d.SearchUser(u) == true)
                {
                    return View("Views/Home/Index.cshtml");
                }
                else
                {
                    return View("failed");
                }
            //}
            //else
            //{
            //    ModelState.AddModelError(string.Empty, "Invalid Credentials");
            //    return View("failed");
            //}
            
        }
    }
}
