using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EventsManager.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; } = "";

        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>(); // One to many with Attendance

        public string UserId { get; set; } = "";
        public ApplicationUser? User { get; set; } // Navigation property for User model
    }
}
