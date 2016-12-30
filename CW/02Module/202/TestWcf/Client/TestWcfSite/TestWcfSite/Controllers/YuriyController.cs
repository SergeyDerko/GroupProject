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
            var expression = new Expression { A = 2, B = 2 };
            ViewBag.Expression = expression;

            var expressions = new Expression();
            //var oneTable = expressions.TableExpressions(3);
            var table = expressions.AllTableExpressions();
            
            return View(table);
        }
        
        

    }
}