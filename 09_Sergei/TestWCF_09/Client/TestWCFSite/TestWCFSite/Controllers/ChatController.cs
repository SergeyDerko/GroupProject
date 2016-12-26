using System.Web.Mvc;
using TestWCFSite.Models;

namespace TestWCFSite.Controllers
{
    public class ChatController : Controller
    {
        // GET: Chat
        public ActionResult Chat()
        {
            var chat = new Chat();
            ViewBag.Name = ".NetBrainChat";
            return View();
        }
    }
}