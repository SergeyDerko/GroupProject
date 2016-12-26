using System.Web.Mvc;

namespace TestWCFSite.Controllers
{
    public class ChatController : Controller
    {
        // GET: Chat
        public ActionResult Chat()
        {
            ViewBag.Title = "Chat";
            return View();
        }
    }
}