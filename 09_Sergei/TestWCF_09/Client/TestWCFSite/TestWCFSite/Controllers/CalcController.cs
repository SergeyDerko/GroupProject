using System.Web.Mvc;

namespace TestWCFSite.Controllers
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