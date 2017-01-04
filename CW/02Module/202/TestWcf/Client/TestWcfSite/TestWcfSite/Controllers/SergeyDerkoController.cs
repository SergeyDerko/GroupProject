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

        public ActionResult User_11(User11 user11)
        {
            var user = new StringBuilder();
            user.Append("Привет тебе - " + user11.Name);
            user.Append(" " + user11.Surname);
            user.Append(" " + user11.Patronymic + "!");
            ViewBag.User = user;
            ViewBag.name = user11.Name;
            return View();
        }
        [HttpPost] // метод принимающий данные с клиента
        public ActionResult Index(CalcModel model, string math)
        {
            model.Action = math;
            ViewBag.Math = model.Action;
            ViewBag.First = model.First;
            ViewBag.Second = model.Second;
            ViewBag.res = model.Result();
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