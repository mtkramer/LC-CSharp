using System;

namespace Studio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius for a circle: ");
            double radius = double.Parse(Console.ReadLine());
            Circle c = new Circle(radius);
            Console.WriteLine(c.Desc("Area"));
            Console.WriteLine(c.Desc("Circumference"));
            Console.WriteLine(c.Desc("Diameter"));
            Console.WriteLine();
            Console.WriteLine("What is the car's mileage?");
            double mileage = double.Parse(Console.ReadLine());
            double fuel = c.Circumference / mileage;
            Console.WriteLine("You will use {0} gallons of fuel to travel the {1} miles around the circle", fuel, c.Circumference);
        }

        public class Circle
        {
            public double Radius { get; set; }
            public int Precision { get; set; }
            public double Area { get; set; }
            public double Circumference { get; set; }
            public double Diameter { get; set; }
            public Circle(double radius)
            {
                Radius = radius;
                Precision = Radius.ToString().Length;
                Area = Math.Round(Math.PI * Math.Pow(Radius, 2), Precision);
                Circumference = Math.Round(2 * Math.PI * Radius, Precision);
                Diameter = Math.Round(2 * Radius, Precision);
            }
            public string Desc(string prop) {
                double calc;
                if (prop.Equals("Area")) { calc = Area; }
                else if (prop.Equals("Circumference")) { calc = Circumference; }
                else if (prop.Equals("Diameter")) { calc = Diameter; }
                else { return "***INVALID PARAM***"; }

                return "The " + prop + " of the circle of radius " + Radius + " is: " + calc;
            }
        }

    }
}
/*
 * 
 */