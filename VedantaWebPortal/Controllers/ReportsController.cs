using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VedantaWebPortal.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Reports >> Daily Perf Reports";
            ViewData["path"] = "http://bldb/ReportServer_SSRS/Pages/ReportViewer.aspx?%2fBalco_Power_Report%2fPerformanceReport&rs:Embed=true";
            return View();
        }
        public IActionResult Daily()
        {
            ViewData["Title"] = "Reports >> Daily Perf Reports";
            ViewData["path"] = "http://bldb/ReportServer_SSRS/Pages/ReportViewer.aspx?%2fBalco_Power_Report%2fPerformanceReport&rs:Embed=true";
            return View("Index");
        }
        public IActionResult RealtimePerf()
        {
            ViewData["Title"] = "Reports >> Real-Time Perf Reports";
            ViewData["path"] = "http://bldb/ReportServer_SSRS/Pages/ReportViewer.aspx?%2fBalco_Power_Report%2fPerformanceReportSnapshot&rs:Embed=true";
            return View("Index");
        }
        public IActionResult DailyGeneration()
        {
            ViewData["Title"] = "Reports >> Daily Generation Reports";
            ViewData["path"] = "http://bldb/ReportServer_SSRS/Pages/ReportViewer.aspx?%2fBalco_Power_Report%2fPerformanceReportSnapshot&rs:Embed=true";//LINK CHNAGEING FURTHER
            return View("Index");
        }
    }
}