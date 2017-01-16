using System.Web.Mvc;
using TestWcfSite.Models.ArtemModels;

namespace TestWcfSite.Controllers
{
    public class ArtemController : Controller
    {
        // GET: Artem
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public ActionResult TableMultiply()
        //{
        //    var expression = new Expression { A = 2, B = 2 };
        //    ViewBag.Expression = expression;

        //    var table = Expression.AllTableExpressions();

        //    return View(table);
        //}

        //public ActionResult Client()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Client(Client client)
        //{
        //    var newClient = new Client { Name = client.Name, Lastname = client.Lastname, Age = client.Age };

        //    return PartialView("_Clientdata", newClient);
        //}

        public ActionResult Temperature()
        {
            var currentTemperature = new Temperature();
            ViewBag.CurrentTemp = currentTemperature;
            return View();
        }
//        public ActionResult CurrencyRate()
//        {
//            var now = new CurrencyRate();

//            return View(now.Current);
//        }
    }
}