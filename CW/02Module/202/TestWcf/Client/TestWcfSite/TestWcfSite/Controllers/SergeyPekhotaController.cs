using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using TestWcfSite.Models;
using TestWcfSite.Models.PikhotaSerhiiModels;

namespace TestWcfSite.Controllers
{
    public class SergeyPekhotaController : Controller
    {
        // GET: SergeyPekhota
        public ActionResult Index()
        {
            var calc = new Calculator
            {
                Value = 2,
                StartIndex = 1,
                Count = 9
            };
            var li = new List<string>() {"111","222","333"};
            
            ViewBag.List = li;
            return View(calc);
        }

        [HttpPost]
        public ActionResult Index(Calculator calc)
        {

            return View("Index",calc);
        }
    }
}