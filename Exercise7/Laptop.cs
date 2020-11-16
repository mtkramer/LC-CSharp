using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7_Inheritance
{
    public class Laptop : Computer
    {
        public readonly string Color;

        public Laptop(string model, double speed, double storage, string color) : base(model, speed, storage) {
            Color = color;
        }

        public string Share()
        {
            return $"Look at my {Color} {Model} laptop!";
        }
    }
}
