using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VedantaWebPortal.Controllers
{
    public class KpisController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {

                ViewData["Title"] = "KPIs >> Overall Plant";
                ViewData["path"] = "OverallPlant";
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        
        public IActionResult OverallPlant()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "KPIs >> Overall Plant";
                ViewData["path"] = "OverallPlant";
                return View("index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public IActionResult PlantHead()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "KPIs >> Plant Head";
                ViewData["path"] = "";
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public IActionResult Cop()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "KPIs >> COP";
                ViewData["path"] = "COP";
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public IActionResult CopBreakup()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "KPIs >> COP";
                ViewData["path"] = "COPBreakup";
                return View("Cop");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}