using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWcfSite.Models.ArtemModels;

namespace TestWcfSite.Controllers
{
    public class ArtemController : Controller
    {
        // GET: Artem
        public ActionResult Index()
        {
<<<<<<< HEAD
            return View();
        }

=======
            
            return View();
        }
>>>>>>> 3fd223ec2c6635520172d6bdf13c78012af802ab
        public ActionResult Temperature()
        {
            var currentTemperature = new Temperature();
            ViewBag.CurrentTemp = currentTemperature;
            return View();
        }
    }
}