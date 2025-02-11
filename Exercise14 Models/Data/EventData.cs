﻿using System.Collections.Generic;
using Exercise14_Models.Models;

namespace Exercise14_Models.Data
{
    public class EventData
    {
        static private Dictionary<int, Event> Events = new Dictionary<int, Event>();

        // GetAll
        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }

        // Add
        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);
        }

        // Remove
        public static void Remove(int id)
        {
            Events.Remove(id);
        }

        // Edit
        public static void Edit(int id, string name, string description)
        {
            Events[id].Name = name;
            Events[id].Description = description;
        }

        // GetById
        public static Event GetById(int id)
        {
            return Events[id];
        }
    }
}
