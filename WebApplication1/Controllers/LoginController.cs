using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Hello";
            return View();
        }
        [HttpPost]
        public ActionResult test(String email, String password)
        {
            User model = new User
            {
                email = email,
                password = password
            };

            return View(model);
        }
       
    }
}