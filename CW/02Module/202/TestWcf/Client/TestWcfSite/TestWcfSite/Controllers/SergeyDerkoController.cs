using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using TestWcfSite.Models.SergeyDerkoModels;

namespace TestWcfSite.Controllers
{
    public class SergeyDerkoController : Controller
    {
        // GET: SergeyDerko
        public ActionResult Index()
        {
            return View();
        }
        private string TableBuilder()
        {
            var str = new StringBuilder();

            for (int i = 2; i < 11; i++)
            {
                str.Append($"{2} x {i} = {2 * i}<br/>");
            }
            return str.ToString();

        }

        public ActionResult Table()
        {
            ViewBag.table = TableBuilder();

            return View();
        }
        private string TableBuilderOll()
        {
            var str = new StringBuilder();

            for (int i = 2; i < 11; i++)
            {
                str.Append($"{ViewBag.A} x {i} = {ViewBag.A * i}<br/>");
            }
            return str.ToString();
        }

        public ActionResult TableOll(int? a)
        {
            ViewBag.A = a;
            ViewBag.tableOll = TableBuilderOll();
            return View();
        }

        public ActionResult MultiplicationTable()
        {
            var exp = new Expression11();
            ViewBag.MTable = exp.MultiplicationTable();
            return View();
        }
    }
}