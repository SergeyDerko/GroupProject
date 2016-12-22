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

        public ActionResult Sum(int id = 0)
        {
            ViewBag.Id = id;
            ViewBag.Result = id + id;
            return View();
        }
    }
}