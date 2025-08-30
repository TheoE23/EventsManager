using System.ComponentModel.DataAnnotations;

namespace EventsManager.Models
{
    public class Location
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";
      
        public ICollection<Event> Events { get; set; } = new List<Event>(); // One to many - With Event

        public decimal? TemperatureC { get; set; } // Use this for WeatherStack
    }
}
