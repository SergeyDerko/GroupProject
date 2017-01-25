using System.Globalization;
using System.Text;
using System.Web.Mvc;
using TestWcfCommon;
using TestWcfSite.Models.SergeyDerkoModels;

namespace TestWcfSite.Controllers
{
    public class SergeyDerkoController : Controller
    {
        
        // GET: SergeyDerko
        public ActionResult Index()
        {
            Logger.Enter("SergeyDerkoController-->Index()");
            return View();
        }

        public ActionResult InfoSiteLog()
        {
            Logger.Enter("SergeyDerkoController-->InfoLogInSite()");
            var model = new ReadLogInSite();
            ViewBag.InfologInSite = model.Read().Replace("#", "<br />");

            return View();
        }

        public ActionResult InfoLog()
        {
            Logger.Enter("SergeyDerkoController-->InfoLog()");
            var model = new ReadLogModel();
            ViewBag.Infologer = model.AddClass().Replace("#", "<br />");
            return View();
        }


        public ActionResult ScanPcResult()
        {
            Logger.Enter("SergeyDerkoController-->scanPcResult()");
            var scanPc = new ScanPcModel();
            ViewBag.Hdd = scanPc.Hdd;
            ViewBag.Cpu = scanPc.Cpu;
            ViewBag.Video = scanPc.Video;
            ViewBag.Memory = scanPc.Memory;
            return View();
        }

        public ActionResult User_11(User11 user11)
        {
            Logger.Enter("SergeyDerkoController-->Uder_11()");
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
            Logger.Enter("SergeyDerkoController-->Index()[HttpPost]-->Calc");
            model.Action = math;
            ViewBag.Math = model.Action;
            ViewBag.First = model.First;
            ViewBag.Second = model.Second;
            ViewBag.res = model.Result();
            Logger.Info("первое значение: "+model.First.ToString(CultureInfo.InvariantCulture));
            Logger.Info("выбранное действие: " + model.Action);
            Logger.Info("второе значение: " + model.Second.ToString(CultureInfo.InvariantCulture));
            Logger.Info("результат действия: " + model.Result());
            return View();
        }
        private string TableBuilder()
        {
            Logger.Enter("SergeyDerkoController-->TableBuilder()");
            var str = new StringBuilder();

            for (int i = 2; i < 11; i++)
            {
                str.Append($"{2} x {i} = {2 * i}<br/>");
            }
            return str.ToString();

        }

        public ActionResult Table()
        {
            Logger.Enter("SergeyDerkoController-->Table()");
            ViewBag.table = TableBuilder();

            return View();
        }
        private string TableBuilderOll()
        {
            Logger.Enter("SergeyDerkoController-->TableBuilderOll()");
            var str = new StringBuilder();

            for (int i = 2; i < 11; i++)
            {
                str.Append($"{ViewBag.A} x {i} = {ViewBag.A * i}<br/>");
            }
            return str.ToString();
        }

        public ActionResult TableOll(int? a)
        {
            Logger.Enter("SergeyDerkoController-->TableOll()");
            ViewBag.A = a;
            ViewBag.tableOll = TableBuilderOll();
            return View();
        }

        public ActionResult MultiplicationTable()
        {
            Logger.Enter("SergeyDerkoController-->MultiplicationTable()");
            var exp = new Expression11();
            ViewBag.MTable = exp.MultiplicationTable();
            return View();
        }
    }
}