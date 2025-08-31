using EventsManager.Models;
using System.ComponentModel.DataAnnotations;

namespace EventsManager.ViewModels  
{
    public class EventCreateViewModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = "";

        [Required]
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
        public string? Description { get; set; }

        [Required (ErrorMessage = "Location is required")]
        public int LocationId { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public List<int> CategoryId { get; set; } = null!;

        public List<Location> Locations { get; set; } = new();
        public List<Category> Categories { get; set; } = new();
    }
}
