using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWcfSite.Models.ArtemModels;

namespace TestWcfSite.Controllers
{
    public class ArtemController : Controller
    {
        // GET: Artem
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Temperature()
        {
            var currentTemperature = new Temperature();
            ViewBag.CurrentTemp = currentTemperature;
            return View();
        }
    }
}