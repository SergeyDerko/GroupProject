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

        public ActionResult Sum(int? id = 0)
        {
            if (id == null)
            {
                ViewBag.Id = 0;
                ViewBag.Result = 0;
            }
            else
            {
                ViewBag.Id = id;
                ViewBag.Result = id + id;
            }
            return View();
        }

        public ActionResult Sum(int? a, int? b)
        {
            if (a != null || b != null)
            {
                ViewBag.A = a;
                ViewBag.B = b;
                ViewBag.Result = a + b;
            }
            return View();
        }
    }
}