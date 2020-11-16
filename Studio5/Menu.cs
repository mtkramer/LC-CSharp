using System;
using System.Collections.Generic;

namespace Studio5_Classes_Pt2_Obj
{
    class Menu
    {
        public readonly string[] Categories = { "Appetizer", "Main Course", "Dessert" };
        public Dictionary<string, MenuItem> MenuItems { get; }
        public readonly DateTime WhenPublished = DateTime.Now;

        public Menu() { MenuItems = new Dictionary<string, MenuItem>(); }
        public void AddMenuItem(string name, MenuItem item) {
            Console.WriteLine($"Checking menu for {name}");
            if (MenuItems.ContainsKey(name))
            {
                Console.WriteLine("An item on the menu already has that name.");
            }
            else if (MenuItems.ContainsValue(item)) {
                Console.WriteLine("Checking menu for similar item.");
                foreach (string key in MenuItems.Keys)
                {
                    if(MenuItems[key].Equals(item))
                    Console.WriteLine($"This item is already be on the menu named {key}.");
                }
            } else
            {
                Console.WriteLine($"No {name} found on menu.  Adding.");
                MenuItems.Add(name, item);
            }
        }
        public void RemoveMenuItem(string name) { MenuItems.Remove(name); }
        public void Order(string name)
        {
            Console.WriteLine("HELLO!  WELCOME TO DINNER!");
            Console.WriteLine("*****************************");
            if (MenuItems[name].Neo) { Console.WriteLine("NEW!!"); }
            Console.WriteLine($"Category: {Categories[MenuItems[name].Category]}");
            Console.WriteLine($"{MenuItems[name]}: {MenuItems[name].Description}");
            Console.WriteLine($"${MenuItems[name].Price}.99");
            Console.WriteLine("*****************************");
        }
        public void PrintMenu()
        {
            Console.WriteLine("HELLO!  WELCOME TO DINNER!");
            Console.WriteLine("Last updated: " + WhenPublished.ToString());
            foreach (string key in MenuItems.Keys)
            {
                Console.WriteLine("*****************************");
                if (MenuItems[key].Neo) { 
                    Console.WriteLine("NEW!!");
                    MenuItems[key].Neo = false;
                }
                Console.WriteLine($"Category: {Categories[MenuItems[key].Category]}");
                Console.WriteLine($"{key}: {MenuItems[key].Description}");
                Console.WriteLine($"${MenuItems[key].Price}.99");
                Console.WriteLine("*****************************");
            }
        }
    }
}
