using EventsManager.Data;
using EventsManager.Models;
using EventsManager.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventsManager.Controllers
{
    public class EventsController : Controller
    {

        private readonly IEventService _eventService;

        public EventsController(IEventService eventService)
        {
            _eventService = eventService;
        }



        public IActionResult Index()
        {
            
            var Events = _eventService.GetAllEvents();

            return View(Events);
        }
    }
}
