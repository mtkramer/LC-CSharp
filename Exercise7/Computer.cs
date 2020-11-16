using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7_Inheritance
{
    public class Computer : AbstractEntity
    {
        public readonly string Model;
        private double Ghz { get; }
        private double Gbyte { get; set; }

        public Computer(string model, double speed, double storage) : base()
        {
            Model = model;
            Ghz = speed;
            Gbyte = storage;
        }

        public string Use()
        {
            return $"Beeb, beep, beep at {Ghz}Ghz speed.";
        }

        public string Store(double gb)
        {
            if(Gbyte < gb) { 
                return $"Not enough memory! Only {Gbyte}Gb remain.";
            }
            else { 
                Gbyte -= gb;
                return $"Storing {gb}Gbytes... There is now {Gbyte}Gb of free storage";
            }
        }

    }
}
/*
Suppose you have a web program that uses these classes and you need to assign a unique ID to every object created from them. 
Each class should have an id field, and no two objects created from any of the classes may have the same value for id. 
Create an abstract class, AbstractEntity, that contains the behavior for assigning and accessing such a unique ID for each 
class that extends it. Add this class to your Technology project above, and add AbstractEntity to the class hierarchy in the 
correct place.
 */