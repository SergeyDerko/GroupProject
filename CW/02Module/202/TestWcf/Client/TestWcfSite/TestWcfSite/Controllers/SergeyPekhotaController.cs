using System.Web.Mvc;
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
    }
}