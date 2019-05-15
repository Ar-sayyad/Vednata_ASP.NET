using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VedantaWebPortal.Controllers
{
    public class ManualController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Manual Entry >> CPP 540 Coal Analysis";
                ViewData["path"] = "";
                return View("manual_cppfiveFourtyCA");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult CppfiveFourtyCA()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Manual Entry >> CPP 540 Coal Analysis";
                ViewData["path"] = "";
                return View("manual_cppfiveFourtyCA");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult CppfiveFourtyDGR()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Manual Entry >> CPP DGR Manual Entry";
                ViewData["path"] = "";
                return View("manual_cppfiveFourtyDGR");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        /********CPP 540 MW *******/

        /********PP 1200 MW *******/
        public IActionResult pptwelveHCA()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Manual Entry >> PP 1200 Coal Analysis";
                ViewData["path"] = "";
                return View("manual_pptwelveHCA");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult ippsixHDGR()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Manual Entry >> IPP 600 DGR Manual Entry";
                ViewData["path"] = "";
                return View("manual_ippsixHDGR");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult cppsixHDGR()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Manual Entry >> CPP 600 DGR Manual Entry";
                ViewData["path"] = "";
                return View("manual_cppsixHDGR");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}