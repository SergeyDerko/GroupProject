using System.Web.Mvc;

namespace TestWCFSite.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            ViewBag.Message = "Calculation page";
            return View();
        }
    }
}