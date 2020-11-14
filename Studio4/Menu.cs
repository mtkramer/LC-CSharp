using System;
using System.Collections.Generic;

namespace Studio4
{
    class Menu
    {
        public string[] Categories = { "Appetizer", "Main Course", "Dessert" };
        public List<MenuItem> MenuItems { get; }
        public DateTime WhenPublished { get; private set; }

        public Menu() { WhenPublished = DateTime.Now; }

        public void AddMenuItem(MenuItem item) { 
            MenuItems.Add(item);
        }
        
        public void PrintMenu()
        {

        }

    }
}
