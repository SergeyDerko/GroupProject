using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWcfSite.Controllers
{
    public class DanilaController : Controller
    {
        // GET: Danila
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MultiTable()
        {
            var expression = new Expression { A = 2, B = 2 };
            ViewBag.Expression = expression;

            var table = Expression.AllTableExpressions();

            return View(table);
        }
    }
}