using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VedantaWebPortal.Controllers
{
    public class PerformanceController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Performance >> Overall Plant";
            ViewData["path"] = "";
            return View();
        }
        public IActionResult OverallPlant()
        {
            ViewData["Title"] = "Performance >> Overall Plant";
            ViewData["path"] = "";
            return View("Index");
        }

        /***********540MW START**************/
        public IActionResult UnitOnefft()
        {
            ViewData["Title"] = "Performance >> 540 MW > Unit #1";
            ViewData["path1"] = "PERFORMANCE";
            ViewData["path2"] = "540MW";
            ViewData["path3"] = "Unit1";
            return View("UnitPerformance");
        }
        public IActionResult UnitTwofft()
        {
            ViewData["Title"] = "Performance >> 540 MW > Unit #2";
            ViewData["path1"] = "PERFORMANCE";
            ViewData["path2"] = "540MW";
            ViewData["path3"] = "Unit2";
            return View("UnitPerformance");
        }
        public IActionResult UnitThreefft()
        {
            ViewData["Title"] = "Performance >> 540 MW > Unit #3";
            ViewData["path1"] = "PERFORMANCE";
            ViewData["path2"] = "540MW";
            ViewData["path3"] = "Unit3";
            return View("UnitPerformance");
        }
        public IActionResult UnitFourfft()
        {
            ViewData["Title"] = "Performance >> 540 MW > Unit #4";
            ViewData["path1"] = "PERFORMANCE";
            ViewData["path2"] = "540MW";
            ViewData["path3"] = "Unit4";
            return View("UnitPerformance");
        }
        public IActionResult BopDcsfft()
        {
            ViewData["Title"] = "Performance >> 540 MW > BOP";
            ViewData["path1"] = "PERFORMANCE";
            ViewData["path2"] = "540MW";
            ViewData["path3"] = "BOP";
            return View("UnitPerformance");
        }
        public IActionResult Boilerfft()
        {
            ViewData["Title"] = "Performance >> 540 MW > Boiler";
            ViewData["path1"] = "PERFORMANCE";
            ViewData["path2"] = "540MW";
            ViewData["path3"] = "Boiler";
            return View("boilerPerformance");
        }
        public IActionResult Turbinefft()
        {
            ViewData["Title"] = "Performance >> 540 MW > Turbine";
            ViewData["path1"] = "PERFORMANCE";
            ViewData["path2"] = "540MW";
            ViewData["path3"] = "Turbine";
            return View("turbinePerformance");
        }

        /***********540MW END**************/

        /***********1200MW START**************/
        public IActionResult UnitOnetwh()
        {
            ViewData["Title"] = "Performance >> 1200 MW > Unit #1";
            ViewData["path1"] = "PERFORMANCE";
            ViewData["path2"] = "1200MW";
            ViewData["path3"] = "Unit1";
            return View("unitPerformance");
        }
        public IActionResult UnitTwotwh()
        {
            ViewData["Title"] = "Performance >> 1200 MW > Unit #2";
            ViewData["path1"] = "PERFORMANCE";
            ViewData["path2"] = "1200MW";
            ViewData["path3"] = "Unit2";
            return View("unitPerformance");
        }
        public IActionResult UnitThreetwh()
        {
            ViewData["Title"] = "Performance >> 1200 MW > Unit #3";
            ViewData["path1"] = "PERFORMANCE";
            ViewData["path2"] = "1200MW";
            ViewData["path3"] = "Unit3";
            return View("unitPerformance");
        }
        public IActionResult UnitFourtwh()
        {
            ViewData["Title"] = "Performance >> 1200 MW > Unit #4";
            ViewData["path1"] = "PERFORMANCE";
            ViewData["path2"] = "1200MW";
            ViewData["path3"] = "Unit4";
            return View("unitPerformance");
        }
        public IActionResult BopDcstwh()
        {
            ViewData["Title"] = "Performance >> 1200 MW > BOP";
            ViewData["path1"] = "PERFORMANCE";
            ViewData["path2"] = "1200MW";
            ViewData["path3"] = "BOP";
            return View("unitPerformance");
        }
        public IActionResult Boilertwh()
        {
            ViewData["Title"] = "Performance >> 1200 MW > Boiler";
            ViewData["path1"] = "PERFORMANCE";
            ViewData["path2"] = "1200MW";
            ViewData["path3"] = "Boiler";
            return View("boilerPerformance");
        }
        public IActionResult Turbinetwh()
        {
            ViewData["Title"] = "Performance >> 1200 MW > Turbine";
            ViewData["path1"] = "PERFORMANCE";
            ViewData["path2"] = "1200MW";
            ViewData["path3"] = "Turbine";
            return View("turbinePerformance");
        }

        /***********1200MW END**************/
    }
}