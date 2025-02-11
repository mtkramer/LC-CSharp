﻿using System.Collections.Generic;
using Exercise15_ViewModel_Validation.Models;

namespace Exercise15_ViewModel_Validation.Data
{
    public class EventData
    {
        static private Dictionary<int, Event> Events = new Dictionary<int, Event>();

        public static IEnumerable<Event> GetAll() { return Events.Values; }
        public static void Add(Event newEvent) { Events.Add(newEvent.Id, newEvent); }
        public static void Remove(int id) { Events.Remove(id); }
        public static Event GetById(int id) { return Events[id]; }
    }
}
