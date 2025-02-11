﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise14_Models.Models
{
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; }
        private static int nextId = 1;

        public Event(string name, string description)
        {
            Name = name;
            Description = description;
            Id = nextId;
            nextId++;
        }

        public Event() { Id = nextId; nextId++; } // constructor required for model binding in EventsController.NewEvent

        public override string ToString()
        {
            return $"{Name}: {Description} id: {Id}";
        }
    }
}
