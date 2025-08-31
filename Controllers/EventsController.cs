using EventsManager.Data;
using EventsManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventsManager.Controllers
{
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EventsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {

            var Events = _db.Events
                .Include(e => e.Categories)
                .Include(e => e.Location)
                .ToList();



            return View(Events);
        }
    }
}
