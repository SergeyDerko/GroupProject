using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWcfSite.Controllers
{
    public class OlegController : Controller
    {
        protected List<string> RowInts;
        // GET: Oleg
        public ActionResult Index()
        {
            ViewBag.First = MultResult();
            return View();
        }

        public ActionResult MultResult()
        {
            string mess;
            for (int i = 1, m; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    m = i*j;
                    mess = i + " * " + j + " = " + m;
                    RowInts.Add(mess);
                    m = 0;                     
                }
            }
            ViewBag.Mess = RowInts;
            return View();
        }
    }
}