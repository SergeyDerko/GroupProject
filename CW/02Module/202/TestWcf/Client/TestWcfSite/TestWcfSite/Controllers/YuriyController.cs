using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWcfSite.Controllers
{
    public class YuriyController : Controller
    {
        // GET: Yuriy
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalcSum(int a, int b)
        {
            ViewBag.Result = a + b;
            return View();
        }
    }
}