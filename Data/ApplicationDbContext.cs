using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EventsManager.Data
{
    public class ApplicationDbContext : IdentityDbContext<EventsManager.Models.ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }

        public DbSet<EventsManager.Models.Event> Events { get; set; }
        public DbSet<EventsManager.Models.Location> Locations { get; set; }
        
        public DbSet<EventsManager.Models.Category> Categories { get; set; }

        public DbSet<EventsManager.Models.Attendance> Attendances { get; set; }

        public DbSet<EventsManager.Models.ApplicationUser> ApplicationUsers { get; set; }
    }
}
