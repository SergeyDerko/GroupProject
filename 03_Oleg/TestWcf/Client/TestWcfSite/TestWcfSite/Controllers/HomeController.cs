using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWcfSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var o = RouteData.Values["a"];
            var con = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}