using Exercise20_ORM_Relationships.Models;

namespace Exercise20_ORM_Relationships.ViewModels
{
    public class EventDetailViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public string CategoryName { get; set; }

        public EventDetailViewModel (Event evt)
        {
            Name = evt.Name;
            Description = evt.Description;
            ContactEmail = evt.ContactEmail;
            CategoryName = evt.Category.Name;
        }
        public EventDetailViewModel () { }
    }
}
