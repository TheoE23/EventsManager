using EventsManager.Data;
using EventsManager.Models;
using EventsManager.Services;
using EventsManager.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

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

        public async Task<IActionResult> Create()
        {
            
            await PopulateDropdowns();
            return View();
        }

        [HttpPost]     
        public async Task<IActionResult> Create(EventCreateViewModel model)
        {
            if (ModelState.IsValid == false)
            {
                await PopulateDropdowns();
                return View(model);
            }

            var newEvent = await _eventService.AddEvent(model);

            if (newEvent == null)
            {
                ModelState.AddModelError("", "Invalid Location or Category, friend.");
                await PopulateDropdowns();
                return View(model);
            }

            return RedirectToAction("Index");
        }

        private async Task PopulateDropdowns()
        {
            ViewBag.Locations = await _eventService.GetAllLocationsAsync();
            ViewBag.Categories = await _eventService.GetAllCategoriesAsync();
        }

    }
}
