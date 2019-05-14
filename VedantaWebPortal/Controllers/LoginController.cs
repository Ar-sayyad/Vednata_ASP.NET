using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VedantaWebPortal.Models;

namespace VedantaWebPortal.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                return Redirect("Home");
            }
            else
            {
                ViewData["Title"] = "Login";
                return View();
            }
        }

        [HttpPost]
        public IActionResult Index(User user)
        {

            User objUser = new User();
            User returnedUser = objUser.Login(user);

            if (returnedUser != null)
            {

                HttpContext.Session.SetString("Id", Convert.ToString(returnedUser.Id));
                HttpContext.Session.SetString("FullName", returnedUser.FirstName + " " + returnedUser.LastName);
                HttpContext.Session.SetString("UserName", returnedUser.UserName);
                HttpContext.Session.SetString("UserType", returnedUser.UserType);

                string uname = HttpContext.Session.GetString("FullName");

                return Content("1");
            }
            else
            {
                return Content("Invalid Login Details.");
            }
        }

        public ActionResult Logout()
        {
           HttpContext.Session.Clear();

            return RedirectToAction("Index", "Login");
        }

    }
}