using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using System.Web.UI.HtmlControls;
using TestWcfSite.Models.PikhotaSerhiiModels;

namespace TestWcfSite.Controllers
{
    public class SergeyPekhotaController : Controller
    {
        // GET: SergeyPekhota
        public ActionResult Index()
        {
            var calc = new Calculator();
            return View(calc);
        }

        [HttpPost]
        public ActionResult Index(Calculator calc)
        {
            return View("Index",calc);
        }

        public ActionResult MultiplyTable()
        {

            ViewBag.Begintd = "<td class = \"tb-pikhota \">";
            ViewBag.Endtd = "</td>";
            ViewBag.Counter = 0;
            ViewBag.TagBr = "<br />";
            ViewData.Model = MultyTables();
            return View();
        }
        

        public ActionResult DivisionTable()
        {
            ViewBag.Begintd = "<td class = \"tb-pikhota \">";
            ViewBag.Endtd = "</td>";
            ViewBag.Counter = 0;
            ViewBag.TagBr = "<br />";
            ViewData.Model = DivTables();
            return View();
        }

        public ActionResult SumTable()
        {
            ViewBag.Begintd = "<td class = \"tb-pikhota \">";
            ViewBag.Endtd = "</td>";
            ViewBag.Counter = 0;
            ViewBag.TagBr = "<br />";
            ViewData.Model = SumTables();
            return View();
        }

        public ActionResult SubstractionTable()
        {
            ViewBag.Begintd = "<td class = \"tb-pikhota \">";
            ViewBag.Endtd = "</td>";
            ViewBag.Counter = 0;
            ViewBag.TagBr = "<br />";
            ViewData.Model = SubTables();
            return View();
        }

        #region ActionMathMethods
        public List<string> MultyTables()
        {
            var list = new List<string>();
            var str = new StringBuilder();
            for (var i = 2; i < 10; i++)
            {
                for (var j = 2; j < 10; j++)
                {
                    str.Append($"{i}x{j}={i * j}");
                    list.Add(str.ToString());
                    str.Clear();
                }
            }
            return list;
        }

        public List<string> DivTables()
        {
            var list = new List<string>();
            var str = new StringBuilder();
            for (var i = 2; i < 10; i++)
            {
                for (var j = 2; j < 10; j++)
                {

                    var result = i % j == 0
                        ? str.Append($"{i}/{j}={i / j}")
                        : str.Append($"{i}/{j}={((double)i / (double)j):N2}");
                    list.Add(result.ToString());
                    str.Clear();
                }

            }
            return list;
        }

        public List<string> SumTables()
        {
            var list = new List<string>();
            var str = new StringBuilder();
            for (var i = 2; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {

                    str.Append($"{i}+{j}={i + j}");
                    list.Add(str.ToString());
                    str.Clear();
                }
            }
            return list;
        }

        public List<string> SubTables()
        {
            var list = new List<string>();
            var str = new StringBuilder();
            for (var i = 2; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {

                    str.Append($"{i}-{j}={i - j}");
                    list.Add(str.ToString());
                    str.Clear();
                }

            }
            return list;
        }
        #endregion

    }
}