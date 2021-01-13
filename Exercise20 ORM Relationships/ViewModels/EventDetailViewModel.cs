using Exercise20_ORM_Relationships.Models;
using System.Collections.Generic;

namespace Exercise20_ORM_Relationships.ViewModels
{
    public class EventDetailViewModel
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public string CategoryName { get; set; }
        public string TagText { get; set; }

        public EventDetailViewModel (Event evt, List<EventTag> eventTags)
        {
            EventId = evt.Id;
            Name = evt.Name;
            Description = evt.Description;
            ContactEmail = evt.ContactEmail;
            CategoryName = evt.Category.Name;
            TagText = "";
            for(int i = 0; i < eventTags.Count; i++)
            {
                TagText += "#" + eventTags[i].Tag.Name;
                if(i < eventTags.Count)
                {
                    TagText += ", ";
                }
            }
        }
        public EventDetailViewModel () { }
    }
}
