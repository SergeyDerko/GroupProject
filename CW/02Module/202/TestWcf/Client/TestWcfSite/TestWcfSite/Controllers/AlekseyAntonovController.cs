using System.Web.Mvc;
using TestWcfSite.Models.AlekseyAntonov;
using ServicesViewerClientLib.ServicesViewerServiceReference;
using System.Collections.Generic;

namespace TestWcfSite.Controllers
{
    public class AlekseyAntonovController : Controller
    {
        // GET: AlekseyAntonov
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _Table()
        {
            return View();
        }

        public ActionResult ServicesViewer()
        {
            ServicesViewerModel one = new ServicesViewerModel();
            AllControllers all = new AllControllers();
           // List<OneService> allServices = one.ListServices();
            ViewBag.allServices=one.ListServices();
            OneController temp;
            all.controllerCollection.Add(new OneController("Calc", "Index"));
            all.controllerCollection.Add(new OneController("AnastasiaNepomiluyev", "TimeOfDay"));
            all.controllerCollection.Add(new OneController("SergeyDerko", "ScanPcResult"));
            all.controllerCollection.Add(new OneController("SergeyDerko", "InfoLog"));
            all.controllerCollection.Add(new OneController("Yuriy", "ExchangeRates"));
            all.controllerCollection.Add(new OneController("Yuri", "CurrencyRate"));
            all.controllerCollection.Add(new OneController("Danila", "Plitka"));
            all.controllerCollection.Add(new OneController("SergeyPekhota", "CurrencyConverter"));
            all.controllerCollection.Add(new OneController("AlekseyAntonov", "ServicesViewer"));
            all.controllerCollection.Add(new OneController("Artem", "Index"));
            all.controllerCollection.Add(new OneController("Oleg", "MeteoTemp"));
        
            ViewBag.allControlls = all.controllerCollection;

            return View();
        }


    }



}