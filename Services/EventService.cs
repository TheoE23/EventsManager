using EventsManager.Data;
using EventsManager.Models;
using EventsManager.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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

        public async Task<Event> AddEvent(EventCreateViewModel model)
        {
            var location = await _db.Locations.FindAsync(model.LocationId);
            var categories = await _db.Categories
                .Where(c => model.CategoryId.Contains(c.Id))
                .ToListAsync();

            if (location == null || categories.Count != model.CategoryId.Count)
            {
                return null;
            }

            var newEvent = new Event
            {
                Name = model.Name,
                Date = model.Date,
                Description = model.Description,
                LocationID = model.LocationId,
                Categories = categories

            };

            _db.Events.Add(newEvent);
            await _db.SaveChangesAsync();
            return newEvent;
        }

        public async Task<List<Location>> GetAllLocationsAsync()
        {
            return await _db.Locations.ToListAsync();
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _db.Categories.ToListAsync();
        }

        public async Task<bool> DeleteEventAsync(int id)
        {
            var eventToDelete = await _db.Events.FindAsync(id);
            if (eventToDelete == null)
            {
                return false;
            }
            _db.Events.Remove(eventToDelete);
            await _db.SaveChangesAsync();
            return true;
        }
    }
}

