using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWcfSite.Controllers
{
    public class Base
    {
        public List<string> TabList;
    }

    public class InList
    {
        string messg;

        public string mesInList(int val, int var, int fin)
        {
            messg = val + " * " + var + " = " + fin;
            return messg;
        }
    }

    public class Mult : Base
    {
        public int x;
        public int y;
        public int z;

        public Mult(int InX, int InY)
        {
            TabList = new List<string>();
            for (x = InX; x <= InY; x++)
            {
                for (y = InX; y <= InY; y++)
                {
                    z = x*y;
                    InList Adder = new InList();
                    TabList.Add(Adder.mesInList(x, y, z));
                }
            }
        }
    }

    public class OlegController : Controller
    {
        // GET: Oleg
        public ActionResult Index()
        {
            Mult Start = new Mult(1, 10);
            foreach (var i in Start.TabList)
            {
                ViewBag.First = i;
            }          ;
            /*Base newBase = new Base();
            foreach (var alya in TabList)
            {
                ViewBag.First = alya;
            }*/
            return View();
        }
                /*
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
                }*/
    }
}