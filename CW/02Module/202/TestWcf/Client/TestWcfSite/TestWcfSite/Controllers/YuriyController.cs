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
            var expression = new Expression { A = 2, B = 1 };
            ViewBag.Expression = expression;
            var oneTable = new Expression(2);
            ViewBag.OneTable = oneTable;
            
            return View();
        }
    }
}