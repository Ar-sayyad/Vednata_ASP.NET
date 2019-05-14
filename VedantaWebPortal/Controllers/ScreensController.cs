using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VedantaWebPortal.Controllers
{
    public class ScreensController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Plant Screen >> Overall Plant";
            ViewData["path"] = "https://bldb:4440/PIVision/#/";
            return View();
        }
        public IActionResult OverallPlant()
        {
            ViewData["Title"] = "Plant Screen >> Overall Plant";
            ViewData["path"] = "https://bldb:4440/PIVision/#/";
            return View("Index");
        }
        /******540MW Unit #1***********/
        public IActionResult OnefftBoiler()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #1 > Boiler";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/25/540MW_U1_Boiler_Overview";
            return View("Index");
        }
        public IActionResult OnefftTurbine()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #1 > Turbine";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/26/540MW_U1_SteamTurbine_Overview";
            return View("Index");
        }
        public IActionResult OnefftCondenser()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #1 > Condenser";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/29/540MW_U1_Condenser_Overview";
            return View("Index");
        }
        public IActionResult OnefftAirpreHeater()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #1 > Air PreHeater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/27/540MW_U1_APHs_Overview";
            return View("Index");
        }
        public IActionResult OnefftHeater()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #1 > HP Heater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/30/540MW_U1_HPHeaters_Overview";
            return View("Index");
        }
        public IActionResult OnefftLPHeater()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #1 > LP Heater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/31/540MW_U1_LPHeaters_Overview";
            return View("Index");
        }
        public IActionResult OnefftPerformance()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #1 > BFPs";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/33/540MW_U1_BFPs_Overview";
            return View("Index");
        }

        /******540MW Unit #2***********/

        public IActionResult TwofftBoiler()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #2 > Boiler";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/78/540MW_U2_Boiler_Overview";
            return View("Index");
        }
        public IActionResult TwofftTurbine()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #2 > Turbine";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/75/540MW_U2_SteamTurbine_Overview";
            return View("Index");
        }
        public IActionResult TwofftCondenser()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #2 > Condenser";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/80/540MW_U2_Condenser_Overview";
            return View("Index");
        }
        public IActionResult TwofftAirpreHeater()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #2 > Air PreHeater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/79/540MW_U2_APHs_Overview";
            return View("Index");
        }
        public IActionResult TwofftHeater()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #2 > HP Heater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/76/540MW_U2_HPHeaters_Overview";
            return View("Index");
        }
        public IActionResult TwofftLPHeater()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #2 > LP Heater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/93/540MW_U2_LPHeaters_Overview";
            return View("Index");
        }
        public IActionResult TwofftPerformance()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #2 > BFPs";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/51/540MW_U2_BFPs_Overview";
            return View("Index");
        }

        /******540MW Unit #3***********/
        public IActionResult ThreefftBoiler()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #3 > Boiler";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/83/540MW_U3_Boiler_Overview";
            return View("Index");
        }
        public IActionResult ThreefftTurbine()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #3 > Turbine";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/86/540MW_U3_SteamTurbine_Overview";
            return View("Index");
        }
        public IActionResult ThreefftCondenser()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #3 > Condenser";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/85/540MW_U3_Condenser_Overview";
            return View("Index");
        }
        public IActionResult ThreefftAirpreHeater()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #3 > Air PreHeater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/82/540MW_U3_APHs_Overview";
            return View("Index");
        }
        public IActionResult ThreefftHeater()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #3 > HP Heater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/84/540MW_U3_HPHeaters_Overview";
            return View("Index");
        }
        public IActionResult ThreefftLPHeater()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #3 > LP Heater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/81/540MW_U3_LPHeaters_Overview";
            return View("Index");
        }
        public IActionResult ThreefftPerformance()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #3 > BFPs";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/55/540MW_U3_BFPs_Overview";
            return View("Index");
        }

        /******540MW Unit #4***********/
        public IActionResult FourfftBoiler()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #4 > Boiler";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/90/540MW_U4_Boiler_Overview";
            return View("Index");
        }
        public IActionResult FourfftTurbine()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #4 > Turbine";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/87/540MW_U4_SteamTurbine_Overview";
            return View("Index");
        }
        public IActionResult FourfftCondenser()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #4 > Condenser";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/88/540MW_U4_Condenser_Overview";
            return View("Index");
        }
        public IActionResult FourfftAirpreHeater()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #4 > Air preHeater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/91/540MW_U4_APHs_Overview";
            return View("Index");
        }
        public IActionResult FourfftHeater()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #4 > HP Heater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/89/540MW_U4_HPHeaters_Overview";
            return View("Index");
        }
        public IActionResult FourfftLPHeater()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #4 > LP Heater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/92/540MW_U4_LPHeaters_Overview";
            return View("Index");
        }
        public IActionResult FourfftPerformance()
        {
            ViewData["Title"] = "Plant Screen >> 540 MW > Unit #4 > BFPs";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/59/540MW_U4_BFPs_Overview";
            return View("Index");
        }

        /********1200 MW START***********/


        /******1200MW Unit #1***********/
        public IActionResult OnetwhBoiler()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #1 > Boiler";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/34/1200MW_U1_Boiler_Overview";
            return View("Index");
        }
        public IActionResult OnetwhTurbine()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #1 > Turbine";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/17/1200MW_U1_SteamTurbine_Overview";
            return View("Index");
        }
        public IActionResult OnetwhCondenser()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #1 > Condenser";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/28/1200MW_U1_Condenser_Overview";
            return View("Index");
        }
        public IActionResult OnetwhAirpreHeater()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #1 > Air preHeater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/20/1200MW_U1_APHs_Overview";
            return View("Index");
        }
        public IActionResult OnetwhHeater()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #1 > HP Heater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/60/1200MW_U1_HPHeaters_Overview";
            return View("Index");
        }
        public IActionResult OnetwhLPHeater()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #1 > LP Heater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/22/1200MW_U1_LPHeaters_Overview";
            return View("Index");
        }
        public IActionResult OnetwhPerformance()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #1 > BFPs";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/32/1200MW_U1_BFPs_Overview";
            return View("Index");
        }
        /******1200MW Unit #2***********/
        public IActionResult TwotwhBoiler()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #2 > Boiler";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/72/1200MW_U2_Boiler_Overview";
            return View("Index");
        }
        public IActionResult TwotwhTurbine()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #2 > Turbine";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/69/1200MW_U2_SteamTurbine_Overview";
            return View("Index");
        }
        public IActionResult TwotwhCondenser()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #2 > Condenser";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/36/1200MW_U2_Condenser_Overview";
            return View("Index");
        }
        public IActionResult TwotwhAirpreHeater()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #2 > Air preHeater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/66/1200MW_U2_APHs_Overview";
            return View("Index");
        }
        public IActionResult TwotwhHeater()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #2 > HP Heater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/21/1200MW_U2_HPHeaters_Overview";
            return View("Index");
        }
        public IActionResult TwotwhLPHeater()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #2 > LP Heater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/63/1200MW_U2_LPHeaters_Overview";
            return View("Index");
        }
        public IActionResult TwotwhPerformance()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #2 > BFPs";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/38/1200MW_U2_BFPs_Overview";
            return View("Index");
        }

        /******1200MW Unit #3***********/
        public IActionResult ThreetwhBoiler()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #3 > Boiler";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/73/1200MW_U3_Boiler_Overview";
            return View("Index");
        }
        public IActionResult ThreetwhTurbine()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #3 > Turbine";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/70/1200MW_U3_SteamTurbine_Overview";
            return View("Index");
        }
        public IActionResult ThreetwhCondenser()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #3 > Condenser";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/37/1200MW_U3_Condenser_Overview";
            return View("Index");
        }
        public IActionResult ThreetwhAirpreHeater()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #3 > Air preHeater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/67/1200MW_U3_APHs_Overview";
            return View("Index");
        }
        public IActionResult ThreetwhHeater()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #3 > HP Heater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/61/1200MW_U3_HPHeaters_Overview";
            return View("Index");
        }
        public IActionResult ThreetwhLPHeater()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #3 > LP Heater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/64/1200MW_U3_LPHeaters_Overview";
            return View("Index");
        }
        public IActionResult ThreetwhPerformance()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #3 > BFPs";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/40/1200MW_U3_BFPs_Overview";
            return View("Index");
        }

        /******1200MW Unit #4***********/
        public IActionResult FourtwhBoiler()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #4 > Boiler";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/74/1200MW_U4_Boiler_Overview";
            return View("Index");
        }
        public IActionResult FourtwhTurbine()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #4 > Turbine";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/71/1200MW_U4_SteamTurbine_Overview";
            return View("Index");
        }
        public IActionResult FourtwhCondenser()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #4 > Condenser";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/42/1200MW_U4_Condenser_Overview";
            return View("Index");
        }
        public IActionResult FourtwhAirpreHeater()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #4 > Air preHeater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/68/1200MW_U4_APHs_Overview";
            return View("Index");
        }
        public IActionResult FourtwhHeater()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #4 > HP Heater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/62/1200MW_U4_HPHeaters_Overview";
            return View("Index");
        }
        public IActionResult FourtwhLPHeater()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #4 > LP Heater";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/65/1200MW_U4_LPHeaters_Overview";
            return View("Index");
        }
        public IActionResult FourtwhPerformance()
        {
            ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #4 > BFPs";
            ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/41/1200MW_U4_BFPs_Overview";
            return View("Index");
        }
    }
}