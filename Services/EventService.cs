using EventsManager.Data;
using EventsManager.Models;
using Microsoft.EntityFrameworkCore;

namespace EventsManager.Services
{
    public class EventService : IEventService
    {
        private readonly ApplicationDbContext _db;
        public EventService(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<Event> GetAllEvents()
        {
            var Events = _db.Events
                    .Include(e => e.Categories)
                    .Include(e => e.Location)
                    .ToList();
            return Events;
        }
    }
}

