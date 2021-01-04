using System.Collections.Generic;

namespace Exercise20_ORM_Relationships.Models
{
    public class EventCategory
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Event> Events { get; set; }

        public EventCategory() { }
        public EventCategory(string name) { Name = name; }
    }
}
