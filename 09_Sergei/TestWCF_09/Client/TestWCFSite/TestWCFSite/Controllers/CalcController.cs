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
    }
}