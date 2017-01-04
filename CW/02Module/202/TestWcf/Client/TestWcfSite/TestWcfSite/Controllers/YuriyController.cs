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
            
            var table = Expression.AllTableExpressions();
            
            return View(table);
        }
        public ActionResult Client()
        {
           return View();
        }
        [HttpPost]
        public ActionResult Client(Client client)
        {
            var newClient = new Client { Name = client.Name, Lastname = client.Lastname, Age = client.Age };

            return PartialView("_Clientdata", newClient);
        }


    }
}