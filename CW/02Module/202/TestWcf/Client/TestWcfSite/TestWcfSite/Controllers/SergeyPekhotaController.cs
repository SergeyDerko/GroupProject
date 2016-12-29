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
            var mult = new Calculator
            {
                Value = 2,
                StartIndex = 2,
                Count = 9
            };

            return View(mult);
        }

        [HttpPost]
        public ActionResult Index(Calculator mult)
        {

            return View("Index",mult);
        }
    }
}