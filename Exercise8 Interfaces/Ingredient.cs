﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise8_Interfaces
{
    public abstract class Ingredient
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public List<string> Allergens { get; set; }

        public Ingredient(string name, double cost, List<string> allergens)
        {
            Name = name;
            Cost = cost;
            Allergens = allergens;
        }

        public override string ToString()
        {
            string allergenString = "";
            foreach(string allergen in Allergens)
            {
                allergenString += allergen + ", ";
            }
            return "Name: " + Name + "\n" + "Cost: $" + Cost + "\n" + "Allergens: " + allergenString + "\n";
        }
    }
}
