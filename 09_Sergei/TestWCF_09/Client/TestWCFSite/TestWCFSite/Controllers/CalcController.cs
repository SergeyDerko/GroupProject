using System.Web.Mvc;

namespace TestWCFSite.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Calc()
        {
            ViewBag.Message = "Calculation page";
            return View();
        }
    }
}