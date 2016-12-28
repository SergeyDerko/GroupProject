using System;
using System.Collections.Generic;
using System.Linq;
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
            var m = new Multiply
            {
                Value = 2,
                StartIndex = 2,
                Count = 9
            };
            return View(m);
        }
    }
}