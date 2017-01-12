using System.Web.Mvc;
using TestWcfSite.Models.DanilaModels;


namespace TestWcfSite.Controllers
{
    public class DanilaController : Controller
    {
        // GET: Danila
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ExpressionD()
        {
            Models.DanilaModels.ExpressionD.B = 2;
            Models.DanilaModels.ExpressionD.A = 2;
            return View();
        }
        public ActionResult Plitka()
        {
            var plitka = new Plitka();
            ViewBag.Plitka = plitka.Error;
            return View();
        }
    }


    }

