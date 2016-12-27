using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWcfSite.Controllers
{
    public class OlegController : Controller
    {
        protected List<mess> RowInts;
        // GET: Oleg
        public ActionResult Index()
        {
            ViewBag.First = MultResult();
            return View();
        }

        public ActionResult MultResult()
        {
            for (int i = 1, m; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    m = i*j;
                    mess newWord = new mess(i, j, m);
                    newWord.GO();
                    RowInts.Add(newWord);
                    m = 0;                    
                }
            }
            ViewBag.Mess = RowInts;
            return View();
        }
    }

    public class mess
    {
        public int first;
        public int second;
        public int third;
        public string newM;

        public mess(int a, int b, int c)
        {
            first = a;
            second = b;
            third = c;
        }

        internal void GO()
        {
            newM = first + " * " + second + " = " + third;
        }
    }
}