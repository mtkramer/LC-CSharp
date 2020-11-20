using System;
using System.Collections.Generic;
using System.Text;

namespace Reading8_Interfaces
{
    class Job
    {
        public string Name;
        private string Description { get; set; }
        public Job(string name, string desc)
        {
            Name = name;
            Description = desc;
        }
    }
}
