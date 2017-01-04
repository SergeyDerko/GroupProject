using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using TestWcfSite.Models.Calc;

namespace TestWcfSite.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            ViewBag.List = TableMultiply();
            return View();
        }

        public ActionResult Sum(int? a, int? b)
        {
            if (b != null)
            {
                if (a != null)
                {
                    var model = new CalcModel();
                    ViewBag.Result = model.Sum((int) a, (int) b);
                    ViewBag.A = a;
                    ViewBag.B = b;
                }
            }
            ViewBag.Action = "+";
            return View();
        }

        public ActionResult Min(int? a, int? b)
        {
            if (a != null || b != null)
            {
                ViewBag.A = a;
                ViewBag.B = b;
                ViewBag.Result = a - b;
                ViewBag.Action = "-";
            }
            return View();
        }

        public ActionResult Sqrt(int? a)
        {
            if (a != null)
            {
                ViewBag.A = a;
                ViewBag.Result = Math.Sqrt((double) a);
                ViewBag.Action = "Sqrt";
            }
            return View();
        }

        public ActionResult Div(int? a, int? b)
        {
            if (a != null && b != null && b != 0)
            {
                ViewBag.A = a;
                ViewBag.B = b;
                ViewBag.Result = a/b;
                ViewBag.Action = "/";
            }
            return View();
        }

        private List<string> TableMultiply()
        {
            var list = new List<string>();
            for (var i = 2; i < 10; i++)
            {
                list.Add(TableBuilder(i));
            }
            return list;
        }

        private string TableBuilder(int num)
        {
            var s = new StringBuilder();
            for (var i = 2; i <= 10; i++)
            {
                s.Append($"{num} x {i} = {num*i}<br/>");
            }
            return s.ToString();
        }
    }
}