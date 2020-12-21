

namespace Exercise19_Persistent_Data.Models
{
    public class EventCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public EventCategory() { }
        public EventCategory(string name) { Name = name; }
    }
}
