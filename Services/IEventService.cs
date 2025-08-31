using EventsManager.Models;

namespace EventsManager.Services
{
    public interface IEventService
    {
        List<Event> GetAllEvents();

    }
}
