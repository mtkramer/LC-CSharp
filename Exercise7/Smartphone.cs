using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7_Inheritance
{
    public class Smartphone : Computer
    {
        public string PhoneNumber { get; set; }

        public Smartphone(string model, double speed, double storage) : base(model, speed, storage) { }

        public string CallNumber(string num)
        {
            if(num.Length != 10)
            {
                return $"Cannot dial {num}, try again.";
            }
            else
            {
                PhoneNumber = num;
                return $"Number {num} was entered.";
            }
        }

        public string Dial()
        {
            return $"Dialing {PhoneNumber}...";
        }

    }
}
