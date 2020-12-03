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

        public Event(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Name}: {Description}";
        }
    }
}
