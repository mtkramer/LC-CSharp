﻿namespace Exercise20_ORM_Relationships.Models
{
    public class EventTag
    {
        public int EventId { get; set; }
        public Event Event { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }

        public EventTag () { }

    }
}
