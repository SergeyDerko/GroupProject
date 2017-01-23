using System.Collections.Generic;
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
            return View();
        }

        [HttpPost] // метод принимающий данные с клиента
        public ActionResult Plitka(Plitka model)
        {

            ViewBag.heightTile = model.heightTile;
            ViewBag.heightWall = model.heightWall;
            ViewBag.widthWall = model.widthWall;
            ViewBag.heightTile = model.heightTile;
            ViewBag.widthTile = model.widthTile;

            ViewBag.res = model.Result();
            return View();
        }

        public ActionResult Map()
        {
            return View();
        }

        
    }
}


