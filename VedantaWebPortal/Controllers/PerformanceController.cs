using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VedantaWebPortal.Controllers
{
    public class PerformanceController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Performance >> Overall Plant";
                ViewData["path"] = "";
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
                ViewData["Title"] = "Performance >> Overall Plant";
                ViewData["path"] = "";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        /***********540MW START**************/
        public IActionResult UnitOnefft()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Performance >> 540 MW > Unit #1";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "540MW";
                ViewData["path3"] = "Unit1";
                return View("UnitPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult UnitTwofft()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Performance >> 540 MW > Unit #2";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "540MW";
                ViewData["path3"] = "Unit2";
                return View("UnitPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult UnitThreefft()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Performance >> 540 MW > Unit #3";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "540MW";
                ViewData["path3"] = "Unit3";
                return View("UnitPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult UnitFourfft()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Performance >> 540 MW > Unit #4";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "540MW";
                ViewData["path3"] = "Unit4";
                return View("UnitPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult BopDcsfft()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Performance >> 540 MW > BOP";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "540MW";
                ViewData["path3"] = "BOP";
                return View("UnitPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult Boilerfft()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Performance >> 540 MW > Boiler";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "540MW";
                ViewData["path3"] = "Boiler";
                return View("boilerPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult Turbinefft()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Performance >> 540 MW > Turbine";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "540MW";
                ViewData["path3"] = "Turbine";
                return View("turbinePerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        /***********540MW END**************/

        /***********1200MW START**************/
        public IActionResult UnitOnetwh()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Performance >> 1200 MW > Unit #1";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "1200MW";
                ViewData["path3"] = "Unit1";
                return View("unitPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult UnitTwotwh()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Performance >> 1200 MW > Unit #2";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "1200MW";
                ViewData["path3"] = "Unit2";
                return View("unitPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult UnitThreetwh()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Performance >> 1200 MW > Unit #3";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "1200MW";
                ViewData["path3"] = "Unit3";
                return View("unitPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult UnitFourtwh()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Performance >> 1200 MW > Unit #4";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "1200MW";
                ViewData["path3"] = "Unit4";
                return View("unitPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult BopDcstwh()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Performance >> 1200 MW > BOP";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "1200MW";
                ViewData["path3"] = "BOP";
                return View("unitPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult Boilertwh()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Performance >> 1200 MW > Boiler";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "1200MW";
                ViewData["path3"] = "Boiler";
                return View("boilerPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult Turbinetwh()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Performance >> 1200 MW > Turbine";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "1200MW";
                ViewData["path3"] = "Turbine";
                return View("turbinePerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        /***********1200MW END**************/
    }
}