using System;
using System.Text;
using System.Web.Mvc;

namespace TestWcfSite.Controllers
{
    public class AnastasiaNepomiluyevController : Controller
    {
        #region ActionResult
        // GET: AnastasiaNepomiluyev
        public ActionResult Index()
        {
            ViewBag.User = new TestWcfSite.Models.AnastasiaNepomiluyev.User();
            ViewBag.TimeOfDayModel = new TestWcfSite.Models.AnastasiaNepomiluyev.TimeOfDayClient();
            ViewBag.TwitterModel = new TestWcfSite.Models.AnastasiaNepomiluyev.Twitter() { CountOfPosts = 10, UserName = "freeCodeCamp" };

            ViewBag.TimeOfDayModel.SetTimeOfDay();
            return View();
        }

        public ActionResult Multiply(int? a, int? b)
        {
            ViewBag.A = a;
            ViewBag.B = b;
            ViewBag.Table = TableBuilder(a, b);
            return View();
        }

        public ActionResult User(TestWcfSite.Models.AnastasiaNepomiluyev.User user)
        {
            ViewBag.UserToString = String.Format("Result: {0} {1} {2}", user.FirstName, user.LastName, user.Age);
            return View(user);
        }

        public ActionResult TimeOfDay()
        {
            var TimeOfDayModel = new TestWcfSite.Models.AnastasiaNepomiluyev.TimeOfDayClient();
            TimeOfDayModel.SetTimeOfDay();
            ViewBag.CurrentTimeOfDay = TimeOfDayModel.TimeOfDay;
            return View();
        }

        public ActionResult Twitter(TestWcfSite.Models.AnastasiaNepomiluyev.Twitter tweeter)
        {
            tweeter.GetTweets();
            return View(tweeter);
        }

        #endregion

        #region  Methods
        private string TableBuilder(int? a, int? b)
        {
            StringBuilder builder = new StringBuilder();
            if (a != null && b != null)
            {
                builder.AppendLine("<table border=\"1\">");
                for (int i = 1; i <= a; i++)
                {
                    for (int j = 1; j <= b; j++)
                    {
                        if(j == 1)
                            builder.AppendLine("<tr>");

                        builder.AppendLine(String.Format("<td>{0}*{1} = {2}</td>", i, j, i*j));

                        if (j == b)
                            builder.AppendLine("</tr>");
                    }
                }
            }
            return builder.ToString();
        }

        #endregion
    }
}