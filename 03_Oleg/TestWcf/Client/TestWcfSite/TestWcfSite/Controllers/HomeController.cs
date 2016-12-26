using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWcfSite.Controllers
{
    public class HomeController : Controller
    {
        public class CalcController : Controller
        {
            // GET: Calc
            public ActionResult Calc()
            {
                ViewBag.Title = "Calculator";
                ViewBag.Message = "Calculation page";
                return View();
            }

            public ActionResult Sum()
            {
                ViewBag.Title = "Calculator";
                ViewBag.Message = "Calculation page";
                return View();
            }
            public ActionResult Del()
            {
                ViewBag.Title = "Calculator";
                ViewBag.Message = "Calculation page";
                return View();
            }

            public ActionResult Mult()
            {
                ViewBag.Title = "Calculator";
                ViewBag.Message = "Calculation page";
                return View();
            }

            public ActionResult Div()
            {
                ViewBag.Title = "Calculator";
                ViewBag.Message = "Calculation page";
                return View();
            }
        }
    }
}