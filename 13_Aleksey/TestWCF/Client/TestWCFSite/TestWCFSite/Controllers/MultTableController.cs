using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWCFSite.Controllers
{
    public class MultTableController : Controller
    {
        // GET: MulTable
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _Table()
        {
            return View();
        }
    }
}