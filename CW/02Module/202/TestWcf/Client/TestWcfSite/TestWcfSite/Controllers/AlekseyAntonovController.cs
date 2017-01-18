using System.Web.Mvc;
using TestWcfSite.Models.AlekseyAntonov;

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
            var servicesVeawer = new ServicesVeawerModel();
            var s = servicesVeawer.ServicesList;
=======
          //  var servicesVeawer = new ServicesVeawerModel();
           // string s=servicesVeawer.ServicesList.
>>>>>>> cd0aea159b8fb3fc8ed545a7ef4f11826260b5f4
            return View();
        }

        
    }

   

}