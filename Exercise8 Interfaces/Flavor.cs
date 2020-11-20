using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise8_Interfaces
{
    public class Flavor : Ingredient
    {
        public Flavor(string name, double cost, List<string> allergens) : base(name, cost, allergens)
        {
        }
    }
}
