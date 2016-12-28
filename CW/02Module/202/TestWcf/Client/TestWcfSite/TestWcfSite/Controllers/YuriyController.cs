using System.Web.Mvc;
//using TestWcfSite.Models.Yuriy;

namespace TestWcfSite.Controllers
{
    public class YuriyController : Controller
    {
        // GET: Yuriy
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TableMultiply()
        {

            //var expression = new Expression {A = 1, B = 2, Operation = Operation.Mult};
            //ViewBag.Expression = expression;
            return View();
        }
    }
}

   