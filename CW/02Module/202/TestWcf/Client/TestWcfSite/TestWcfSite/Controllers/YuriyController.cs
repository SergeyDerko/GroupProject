using System.Web.Mvc;
using TestWcfSite.Models.Yuriymodels;

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

            var expression = new Expression {A = 1, B = 1, Operation = Operation.Mult};
            var expression2 = new Expression {A = 1, B = 2, Operation = Operation.Mult};
            
            ViewBag.Expression = expression;
            ViewBag.Expression2 = expression2;
            return View();
        }
    }
}

   