using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VedantaWebPortal.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Reports >> Daily Perf Reports";
                ViewData["path"] = "http://bldb/ReportServer_SSRS/Pages/ReportViewer.aspx?%2fBalco_Power_Report%2fPerformanceReport&rs:Embed=true";
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult Daily()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Reports >> Daily Perf Reports";
                ViewData["path"] = "http://bldb/ReportServer_SSRS/Pages/ReportViewer.aspx?%2fBalco_Power_Report%2fPerformanceReport&rs:Embed=true";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult RealtimePerf()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Reports >> Real-Time Perf Reports";
                ViewData["path"] = "http://bldb/ReportServer_SSRS/Pages/ReportViewer.aspx?%2fBalco_Power_Report%2fPerformanceReportSnapshot&rs:Embed=true";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult DailyGeneration() //LINK CHNAGEING FURTHER
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Reports >> Daily Generation Reports";
                ViewData["path"] = "http://bldb/ReportServer_SSRS/Pages/ReportViewer.aspx?%2fBalco_Power_Report%2fPerformanceReportSnapshot&rs:Embed=true";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}