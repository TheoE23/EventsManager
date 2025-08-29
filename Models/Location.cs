﻿namespace EventsManager.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
      
        public ICollection<Event> Events { get; set; } = new List<Event>(); // One to many - With Event
    }
}
