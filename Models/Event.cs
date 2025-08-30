using System.ComponentModel.DataAnnotations;

namespace EventsManager.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = "";
        public DateTime? Date { get; set; }

        public string? Description { get; set; }

        public int LocationID { get; set; } // Foreign key for Location

        public Location? Location { get; set; } // Navigation property cuz I need it to access Location details
        public decimal? TemperatureC { get; set; } // Use this for WeatherStack

        public ICollection<Category> Categories { get; set; } = new List<Category>(); // Many to many - With Category

        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>(); // One to many - With Attendance
    }
}
