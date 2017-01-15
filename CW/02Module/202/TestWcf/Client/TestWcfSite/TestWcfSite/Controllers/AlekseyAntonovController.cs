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

        public ActionResult ServicesVeawer()
        {
            var servicesVeawer = new ServicesVeawerModel();
            string s=servicesVeawer.ServicesList.
            return View();
        }

        
    }

   

}