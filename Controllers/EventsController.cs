using Microsoft.AspNetCore.Mvc;

namespace EventsManager.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
