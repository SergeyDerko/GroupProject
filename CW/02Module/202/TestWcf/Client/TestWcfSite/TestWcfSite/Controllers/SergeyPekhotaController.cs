using System.Web.Mvc;
using System.Web.UI.HtmlControls;
using TestWcfSite.Models.PikhotaSerhiiModels;

namespace TestWcfSite.Controllers
{
    public class SergeyPekhotaController : Controller
    {
        // GET: SergeyPekhota
        public ActionResult Index(int value = 2,int index=1,int count=9)
        {
            var calc = new Calculator
            {
                Value = value,
                StartIndex = index,
                Count = count
            };
            return View(calc);
        }

        [HttpPost]
        public ActionResult Index(Calculator calc)
        {
            return View("Index",calc);
        }

        public ActionResult MultiplyTable(TablesOfMathActions table)
        {
            ViewBag.Counter = 0;
            return View(table);
        }

        public ActionResult DivisionTable(TablesOfMathActions table)
        {
            ViewBag.Counter = 0;
            return View(table);
        }

        public ActionResult SumTable(TablesOfMathActions table)
        {
            ViewBag.Counter = 0;
            return View(table);
        }

        public ActionResult SubstractionTable(TablesOfMathActions table)
        {
            ViewBag.Counter = 0;
            return View(table);
        }
    }
}