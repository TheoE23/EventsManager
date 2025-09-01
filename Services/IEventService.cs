using EventsManager.Models;
using EventsManager.ViewModels;

namespace EventsManager.Services
{
    public interface IEventService
    {
        List<Event> GetAllEvents();

        Task<Event> AddEvent(EventCreateViewModel model);

        Task<List<Location>> GetAllLocationsAsync();

        Task<List<Category>> GetAllCategoriesAsync();

        Task<bool> DeleteEventAsync(int id);

    }
}
