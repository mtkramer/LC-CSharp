using System;

namespace Studio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = -1;
            while(radius <= 0)
            {
                Console.WriteLine("Enter the radius for a circle: ");
                radius = double.Parse(Console.ReadLine());
            }
            Circle c = new Circle(radius);
            c.Desc("Area");
            c.Desc("Circumference");
            c.Desc("Diameter");
            Console.WriteLine();
            Console.WriteLine("What is the car's mileage?");
            double mileage = double.Parse(Console.ReadLine());
            double fuel = Math.Round(c.Circumference / mileage, c.Precision);
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
                if (Radius.ToString().Contains('.')){
                    string temp = Radius.ToString();
                    Precision = temp.Length - temp.IndexOf('.') - 1;
                }
                else { Precision = Radius.ToString().Length; }
                Area = Math.Round(Math.PI * Math.Pow(Radius, 2), Precision);
                Circumference = Math.Round(2 * Math.PI * Radius, Precision);
                Diameter = 2 * Radius;
            }
            public void Desc(string prop) {
                double calc = 0;
                if (prop.Equals("Area")) { calc = Area; }
                else if (prop.Equals("Circumference")) { calc = Circumference; }
                else if (prop.Equals("Diameter")) { calc = Diameter; }
                else { Console.WriteLine("***INVALID PARAM***"); }

                Console.WriteLine("The {0} of the circle of radius {1} is: {2}", prop, Radius, calc);
            }
        }

    }
}
