using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VedantaWebPortal.Controllers
{
    public class BalcoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}