// Controllers/HomeController.cs

using Microsoft.AspNet.SignalR;
using SignalR.Hubs;
using System.Web.Mvc;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public JsonResult SendMessage(string targetUserId, string message)
    {
        // Handle signaling (exchange SDP offers and answers) here
        // You might store signaling data in memory or a database
        // For simplicity, we just echo the message back
        return Json(new { targetUserId, message });
    }
}
