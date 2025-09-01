using EventsManager.Data;
using EventsManager.Models;
using EventsManager.Services;
using EventsManager.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using X.PagedList;
using X.PagedList.Extensions;

namespace EventsManager.Controllers
{
    public class EventsController : Controller
    {

        private readonly IEventService _eventService;
       

        public EventsController(IEventService eventService)
        {
            _eventService = eventService;
        }



        public IActionResult Index(int page = 1)
        {
            int pageSize = 10;

            var Events = _eventService.GetAllEvents()
                .ToPagedList(page, pageSize);   


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

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteEvent = await _eventService.DeleteEventAsync(id);
            if (deleteEvent == false)
            {
                ViewBag.ErrorMessage = "Didn't find the event";
                return View();
            }
            ViewBag.Message = "Event was deleted.";
            return View();
        }
    }
}
