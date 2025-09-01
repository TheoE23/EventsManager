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
                new Location { Id = 3, Name = "Chicago" },
                new Location { Id = 4, Name = "San Francisco" },
                new Location { Id = 5, Name = "Miami" },
                new Location { Id = 6, Name = "Seattle" },
                new Location { Id = 7, Name = "Austin" },
                new Location { Id = 8, Name = "Boston" },
                new Location { Id = 9, Name = "Paris" },
                new Location { Id = 10, Name = "Tokyo" },
                new Location { Id = 11, Name = "Berlin" },
                new Location { Id = 12, Name = "London" },
                new Location { Id = 13, Name = "Toronto" },
                new Location { Id = 14, Name = "Vancouver" },
                new Location { Id = 15, Name = "Sydney" },
                new Location { Id = 16, Name = "Melbourne" },
                new Location { Id = 17, Name = "Rome" },
                new Location { Id = 18, Name = "Madrid" },
                new Location { Id = 19, Name = "Dublin" },
                new Location { Id = 20, Name = "Amsterdam" },
                new Location { Id = 21, Name = "Copenhagen" },
                new Location { Id = 22, Name = "Oslo" },
                new Location { Id = 23, Name = "Helsinki" },
                new Location { Id = 24, Name = "Vienna" },
                new Location { Id = 25, Name = "Brussels" },
                new Location { Id = 26, Name = "Zurich" },
                new Location { Id = 27, Name = "Lisbon" },
                new Location { Id = 28, Name = "Prague" },
                new Location { Id = 29, Name = "Budapest" },
                new Location { Id = 30, Name = "Warsaw" },
                new Location { Id = 31, Name = "Athens" },
                new Location { Id = 32, Name = "Istanbul" },
                new Location { Id = 33, Name = "Seoul" },
                new Location { Id = 34, Name = "Hong Kong" },
                new Location { Id = 35, Name = "Bangkok" },
                new Location { Id = 36, Name = "Dubai" },
                new Location { Id = 37, Name = "Mexico City" },
                new Location { Id = 38, Name = "Buenos Aires" },
                new Location { Id = 39, Name = "Sao Paulo" },
                new Location { Id = 40, Name = "Lima" },
                new Location { Id = 41, Name = "Cairo" },
                new Location { Id = 42, Name = "Johannesburg" },
                new Location { Id = 43, Name = "Nairobi" },
                new Location { Id = 44, Name = "Sofia" },
                new Location { Id = 45, Name = "Moscow" },
                new Location { Id = 46, Name = "Hanoi" },
                new Location { Id = 47, Name = "Manila" },
                new Location { Id = 48, Name = "Varna" },
                new Location { Id = 49, Name = "Tirana" },
                new Location { Id = 50, Name = "Skopje" }

            );

            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Music" },
                new Category { Id = 2, Name = "Art" },
                new Category { Id = 3, Name = "Technology" },
                new Category { Id = 4, Name = "Sports" },
                new Category { Id = 5, Name = "Education" },
                new Category { Id = 6, Name = "Health" },
                new Category { Id = 7, Name = "Business" },
                new Category { Id = 8, Name = "Travel" },
                new Category { Id = 9, Name = "Food & Drink" },
                new Category { Id = 10, Name = "Fashion" },
                new Category { Id = 11, Name = "Film & TV" }
            );

            builder.Entity<Event>().HasData(
                new Event { Id = 1, Name = "Jazz Concert", Date = new DateTime(2024, 11, 15), Description = "An evening of smooth jazz.", LocationID = 1},
                new Event { Id = 2, Name = "Art Exhibition", Date = new DateTime(2024, 12, 5), Description = "Showcasing modern art.", LocationID = 2 },
                new Event { Id = 3, Name = "Tech Conference", Date = new DateTime(2025, 1, 20), Description = "Latest in tech innovations.", LocationID = 3 },
                new Event { Id = 4, Name = "Football Match", Date = new DateTime(2024, 10, 10), Description = "Local teams face off.", LocationID = 1 }
            );

            builder.Entity<Event>()
                .HasMany(e => e.Categories)
                .WithMany(c => c.Events)
                .UsingEntity(j => j.HasData(
                   new {EventsId = 1, CategoriesId = 1},
                   new {EventsId = 2, CategoriesId = 2},
                   new {EventsId = 3, CategoriesId = 3 },
                   new {EventsId = 4, CategoriesId = 4 }
                 ));        
        }
    }
}
