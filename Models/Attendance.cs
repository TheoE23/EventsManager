namespace EventsManager.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public int EventId { get; set; } // Foreign key for Event
        
    }
}
