namespace EventsManager.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public int EventId { get; set; } // Foreign key for Event

        public Event? Event { get; set; } // Navigation property cuz I need it to access Event details

        public string ApplicationUserId { get; set; } = ""; // Foreign key for ApplicationUser

        public ApplicationUser? ApplicationUser { get; set; } // Navigation property cuz I need it to access User details

    }
}
