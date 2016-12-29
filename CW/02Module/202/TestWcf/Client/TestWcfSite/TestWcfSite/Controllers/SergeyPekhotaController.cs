using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using TestWcfSite.Models;

namespace TestWcfSite.Controllers
{
    public class SergeyPekhotaController : Controller
    {
        // GET: SergeyPekhota
        public ActionResult Index()
        {
            var mult = new Multiply
            {
                Value = 2,
                StartIndex = 2,
                Count = 9
            };

            return View(mult);
        }

        [HttpPost]
        public ActionResult Index(Multiply mult)
        {

            return View("Index",mult);
        }
    }
}