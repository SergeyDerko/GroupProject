using System.Collections.Generic;
using System.Text;
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
            return View();
        }

        public string MultResult()
        {
            var str = new StringBuilder();
            Mult Start = new Mult(1, 10);
            foreach (var i in Start.TabList)
            {
                str.Append(i);
            };
            /*Base newBase = new Base();
            foreach (var alya in TabList)
            {
                ViewBag.First = alya;
            }*/
            return str.ToString();
        }

        public ActionResult Table()
        {
            ViewBag.table = MultResult();

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