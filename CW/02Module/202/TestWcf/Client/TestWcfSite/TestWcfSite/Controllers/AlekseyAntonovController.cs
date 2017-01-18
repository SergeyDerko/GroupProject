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
<<<<<<< HEAD
            ServicesViewerModel one = new ServicesViewerModel();
           // List<OneService> allServices = one.ListServices();
            ViewBag.allServices=one.ListServices();
=======
            //  var servicesVeawer = new ServicesVeawerModel();
            // string s=servicesVeawer.ServicesList.
>>>>>>> 56f72662ddd9270d59636c49ee8baa8bfea5197e
            return View();
        }


    }



}