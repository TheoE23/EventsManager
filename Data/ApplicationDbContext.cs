using EventsManager.Models;
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Location>().HasData(
                new Location { Id = 1, Name = "New York"},
                new Location { Id = 2, Name = "Los Angeles"},
                new Location { Id = 3, Name = "Chicago" }
            );

            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Music" },
                new Category { Id = 2, Name = "Art" },
                new Category { Id = 3, Name = "Technology" },
                new Category { Id = 4, Name = "Sports" }
            );

            builder.Entity<Event>().HasData(
                new Event { Id = 1, Name = "Jazz Concert", Date = new DateTime(2024, 11, 15), Description = "An evening of smooth jazz.", LocationID = 1},
                new Event { Id = 2, Name = "Art Exhibition", Date = new DateTime(2024, 12, 5), Description = "Showcasing modern art.", LocationID = 2 },
                new Event { Id = 3, Name = "Tech Conference", Date = new DateTime(2025, 1, 20), Description = "Latest in tech innovations.", LocationID = 3 }
            );

            builder.Entity<Event>()
                .HasMany(e => e.Categories)
                .WithMany(c => c.Events)
                .UsingEntity(j => j.HasData(
                   new {EventsId = 1, CategoriesId = 1},
                   new {EventsId = 2, CategoriesId = 2},
                   new {EventsId = 3, CategoriesId = 3 }
                 ));
        }
    }
}
