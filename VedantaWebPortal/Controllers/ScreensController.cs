using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VedantaWebPortal.Controllers
{
    public class ScreensController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> Overall Plant";
                ViewData["path"] = "https://bldb:4440/PIVision/#/";
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
                ViewData["Title"] = "Plant Screen >> Overall Plant";
                ViewData["path"] = "https://bldb:4440/PIVision/#/";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        /******540MW Unit #1***********/
        public IActionResult OnefftBoiler()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #1 > Boiler";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/25/540MW_U1_Boiler_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult OnefftTurbine()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #1 > Turbine";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/26/540MW_U1_SteamTurbine_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult OnefftCondenser()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #1 > Condenser";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/29/540MW_U1_Condenser_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult OnefftAirpreHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #1 > Air PreHeater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/27/540MW_U1_APHs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult OnefftHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #1 > HP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/30/540MW_U1_HPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult OnefftLPHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #1 > LP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/31/540MW_U1_LPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult OnefftPerformance()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #1 > BFPs";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/33/540MW_U1_BFPs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        /******540MW Unit #2***********/

        public IActionResult TwofftBoiler()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #2 > Boiler";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/78/540MW_U2_Boiler_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult TwofftTurbine()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #2 > Turbine";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/75/540MW_U2_SteamTurbine_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult TwofftCondenser()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #2 > Condenser";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/80/540MW_U2_Condenser_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult TwofftAirpreHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #2 > Air PreHeater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/79/540MW_U2_APHs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult TwofftHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #2 > HP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/76/540MW_U2_HPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult TwofftLPHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #2 > LP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/93/540MW_U2_LPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult TwofftPerformance()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #2 > BFPs";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/51/540MW_U2_BFPs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        /******540MW Unit #3***********/
        public IActionResult ThreefftBoiler()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #3 > Boiler";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/83/540MW_U3_Boiler_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult ThreefftTurbine()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #3 > Turbine";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/86/540MW_U3_SteamTurbine_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult ThreefftCondenser()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #3 > Condenser";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/85/540MW_U3_Condenser_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult ThreefftAirpreHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #3 > Air PreHeater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/82/540MW_U3_APHs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult ThreefftHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #3 > HP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/84/540MW_U3_HPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult ThreefftLPHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #3 > LP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/81/540MW_U3_LPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult ThreefftPerformance()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #3 > BFPs";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/55/540MW_U3_BFPs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        /******540MW Unit #4***********/
        public IActionResult FourfftBoiler()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #4 > Boiler";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/90/540MW_U4_Boiler_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult FourfftTurbine()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #4 > Turbine";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/87/540MW_U4_SteamTurbine_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult FourfftCondenser()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #4 > Condenser";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/88/540MW_U4_Condenser_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult FourfftAirpreHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #4 > Air preHeater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/91/540MW_U4_APHs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult FourfftHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #4 > HP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/89/540MW_U4_HPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult FourfftLPHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #4 > LP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/92/540MW_U4_LPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult FourfftPerformance()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #4 > BFPs";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/59/540MW_U4_BFPs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        /********1200 MW START***********/


        /******1200MW Unit #1***********/
        public IActionResult OnetwhBoiler()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #1 > Boiler";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/34/1200MW_U1_Boiler_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult OnetwhTurbine()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #1 > Turbine";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/17/1200MW_U1_SteamTurbine_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult OnetwhCondenser()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #1 > Condenser";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/28/1200MW_U1_Condenser_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult OnetwhAirpreHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #1 > Air preHeater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/20/1200MW_U1_APHs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult OnetwhHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #1 > HP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/60/1200MW_U1_HPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult OnetwhLPHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #1 > LP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/22/1200MW_U1_LPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult OnetwhPerformance()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #1 > BFPs";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/32/1200MW_U1_BFPs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        /******1200MW Unit #2***********/
        public IActionResult TwotwhBoiler()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #2 > Boiler";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/72/1200MW_U2_Boiler_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult TwotwhTurbine()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #2 > Turbine";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/69/1200MW_U2_SteamTurbine_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult TwotwhCondenser()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #2 > Condenser";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/36/1200MW_U2_Condenser_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult TwotwhAirpreHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #2 > Air preHeater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/66/1200MW_U2_APHs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult TwotwhHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #2 > HP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/21/1200MW_U2_HPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult TwotwhLPHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #2 > LP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/63/1200MW_U2_LPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult TwotwhPerformance()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #2 > BFPs";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/38/1200MW_U2_BFPs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        /******1200MW Unit #3***********/
        public IActionResult ThreetwhBoiler()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #3 > Boiler";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/73/1200MW_U3_Boiler_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult ThreetwhTurbine()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #3 > Turbine";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/70/1200MW_U3_SteamTurbine_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult ThreetwhCondenser()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #3 > Condenser";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/37/1200MW_U3_Condenser_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult ThreetwhAirpreHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #3 > Air preHeater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/67/1200MW_U3_APHs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult ThreetwhHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #3 > HP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/61/1200MW_U3_HPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult ThreetwhLPHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #3 > LP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/64/1200MW_U3_LPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult ThreetwhPerformance()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #3 > BFPs";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/40/1200MW_U3_BFPs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        /******1200MW Unit #4***********/
        public IActionResult FourtwhBoiler()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #4 > Boiler";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/74/1200MW_U4_Boiler_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult FourtwhTurbine()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #4 > Turbine";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/71/1200MW_U4_SteamTurbine_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult FourtwhCondenser()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #4 > Condenser";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/42/1200MW_U4_Condenser_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult FourtwhAirpreHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #4 > Air preHeater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/68/1200MW_U4_APHs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult FourtwhHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #4 > HP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/62/1200MW_U4_HPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult FourtwhLPHeater()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #4 > LP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/65/1200MW_U4_LPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult FourtwhPerformance()
        {
            if (HttpContext.Session.GetString("UserType") != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #4 > BFPs";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/41/1200MW_U4_BFPs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}