using System;

namespace Reading6_Unit_Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", "Prius", 10, 50);
            Console.WriteLine(car.Make + " - " + car.Model);
        }
    }
}
