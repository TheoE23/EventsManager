using System.ComponentModel.DataAnnotations;

namespace EventsManager.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public DateTime? Date { get; set; }

        public string? Description { get; set; }

        public int LocationID { get; set; } // Foreign key for Location
        public decimal? TemperatureC { get; set; } // Use this for WeatherStack
    }
}
