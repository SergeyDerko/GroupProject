using System;
using System.Web.Mvc;

namespace TestWcfSite.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sum(int? a, int? b)
        {
            if (a != null || b != null)
            {
                ViewBag.A = a;
                ViewBag.B = b;
                ViewBag.Result = a + b;
                ViewBag.Action = "+";
            }
            return View();
        }

        public ActionResult Min(int? a, int? b)
        {
            if (a != null || b != null)
            {
                ViewBag.A = a;
                ViewBag.B = b;
                ViewBag.Result = a - b;
                ViewBag.Action = "-";
            }
            return View();
        }

        public ActionResult Sqrt(int? a)
        {
            if (a != null)
            {
                ViewBag.A = a;
                ViewBag.Result = Math.Sqrt((double)a);
                ViewBag.Action = "Sqrt";
            }
            return View();
        }
    }
}