using System.Web.Mvc;
using System.ServiceModel;
using TestWCFCommon;
using System;


namespace TestWCFSite.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sum(int? x, int? y)
        {
            ChannelFactory<ICalc> factory = new ChannelFactory<ICalc>("WSHttpBinding_ICalc");
            ICalc channel = factory.CreateChannel();
            if (x != null && y != null)
            {

                ViewBag.Result = channel.Sum(Convert.ToInt32(x), Convert.ToInt32(y));//x + y;
            }
            return View();
        }

        public ActionResult Sub(int? x, int? y)
        {
            ChannelFactory<ICalc> factory = new ChannelFactory<ICalc>("WSHttpBinding_ICalc");
            ICalc channel = factory.CreateChannel();
            if (x != null && y != null)
            {
                ViewBag.Result = channel.Sub(Convert.ToInt32(x), Convert.ToInt32(y));//x - y;
            }
            return View();
        }

        public ActionResult Mult(int? x, int? y)
        {
            ChannelFactory<ICalc> factory = new ChannelFactory<ICalc>("WSHttpBinding_ICalc");
            ICalc channel = factory.CreateChannel();
            if (x != null && y != null)
            {
                ViewBag.Result = channel.Mult(Convert.ToInt32(x), Convert.ToInt32(y));//x * y;
            }
            return View();
        }

        public ActionResult Div(double? x, double? y)
        {
            ChannelFactory<ICalc> factory = new ChannelFactory<ICalc>("WSHttpBinding_ICalc");
            ICalc channel = factory.CreateChannel();
            if (x != null && y != null)
            {
                ViewBag.Result = channel.Div(Convert.ToInt32(x), Convert.ToInt32(y));//x / y;
            }
            return View();
        }
    }
}