using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VedantaWebPortal.Controllers
{
    public class ManualController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Manual Entry >> CPP 540 Coal Analysis";
            ViewData["path"] = "";
            return View("manual_cppfiveFourtyCA");
        }
        public IActionResult CppfiveFourtyCA()
        {
            ViewData["Title"] = "Manual Entry >> CPP 540 Coal Analysis";
            ViewData["path"] = "";
            return View("manual_cppfiveFourtyCA");
        }
        public IActionResult CppfiveFourtyDGR()
        {
            ViewData["Title"] = "Manual Entry >> CPP DGR Manual Entry";
            ViewData["path"] = "";
            return View("manual_cppfiveFourtyDGR");
        }
        /********CPP 540 MW *******/

        /********PP 1200 MW *******/
        public IActionResult pptwelveHCA()
        {
            ViewData["Title"] = "Manual Entry >> PP 1200 Coal Analysis";
            ViewData["path"] = "";
            return View("manual_pptwelveHCA");
        }
        public IActionResult ippsixHDGR()
        {
            ViewData["Title"] = "Manual Entry >> IPP 600 DGR Manual Entry";
            ViewData["path"] = "";
            return View("manual_ippsixHDGR");
        }
        public IActionResult cppsixHDGR()
        {
            ViewData["Title"] = "Manual Entry >> CPP 600 DGR Manual Entry";
            ViewData["path"] = "";
            return View("manual_cppsixHDGR");
        }
    }
}