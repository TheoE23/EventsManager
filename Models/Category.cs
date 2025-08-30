using System.ComponentModel.DataAnnotations;

namespace EventsManager.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";
        public ICollection<Event> Events { get; set; } = new List<Event>(); // Many to many with Event
    }
}
