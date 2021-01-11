using Exercise20_ORM_Relationships.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Exercise20_ORM_Relationships.ViewModels
{
    public class AddEventTagViewModel
    {
        public int EventId { get; set; }
        public Event Event { get; set; }
        public List<SelectListItem> Tags { get; set; }
        public int TagId { get; set; }

        public AddEventTagViewModel () { }
        public AddEventTagViewModel (Event evt, List<Tag> possibleTags) 
        {
            Tags = new List<SelectListItem>();
            foreach(var tag in possibleTags)
            {
                Tags.Add(new SelectListItem
                {
                    Value = tag.Id.ToString(),
                    Text = tag.Name
                });
            }
            Event = evt;
        }

    }
}
