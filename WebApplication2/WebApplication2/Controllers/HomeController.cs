using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;
using Microsoft.Data.SqlClient;
namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult users()
        {
            data d = new data();
            List<user> getAllData = d.GetAllData();

            return View("users", getAllData);
           
        }
        public ActionResult Privacy()
        {
            

            return View();

        }
        public ActionResult about()
        {


            return View();

        }
        [HttpGet]
        public ActionResult contact()
        {


            return View();

        }
        //[HttpPost]
        //public ActionResult contact(user u)
        //{

        //    data d=new data();
        //    bool ok = d.AddUser(u);
        //    if(ok==true)
        //    {
        //        return View("")
        //    }

        //    return View();

        //}
    }
}