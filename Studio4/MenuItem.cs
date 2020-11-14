using System;
using System.Collections.Generic;

namespace Studio4
{
    class MenuItem
    {
        public string Description { get; set; }
        public float Price { get; }
        public int Category { get; set; }
        public bool Neo { get; set; }

        public MenuItem(string descript, float price, int category)
        {
            Description = descript;
            Price = price;
            Category = category;
            Neo = true;
        }

    }
}
