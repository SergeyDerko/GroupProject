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
           // List<OneService> allServices = one.ListServices();
            ViewBag.allServices=one.ListServices();

            //  var servicesVeawer = new ServicesVeawerModel();
            // string s=servicesVeawer.ServicesList.

            return View();
        }


    }



}