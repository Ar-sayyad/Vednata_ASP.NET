using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace VedantaWebPortal.Controllers
{
    public class KpisController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "KPIs >> Overall Plant";
            ViewData["path"] = "OverallPlant";
            return View();
        }
        
        public IActionResult OverallPlant()
        {
            ViewData["Title"] = "KPIs >> Overall Plant";
            ViewData["path"] = "OverallPlant";
            return View("index");
        }

        public IActionResult PlantHead()
        {
            ViewData["Title"] = "KPIs >> Plant Head";
            ViewData["path"] = "";
            return View();
        }

        public IActionResult Cop()
        {
            ViewData["Title"] = "KPIs >> COP";
            ViewData["path"] = "COP";
            return View();
        }

        public IActionResult CopBreakup()
        {
            ViewData["Title"] = "KPIs >> COP";
            ViewData["path"] = "COPBreakup";
            return View("Cop");
        }
    }
}