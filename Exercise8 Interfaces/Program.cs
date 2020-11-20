using System;
using System.Collections.Generic;

namespace Exercise8_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            availableFlavors.Sort(new FlavorComparer());

            availableCones.Sort(new ConeComparer());

            Console.WriteLine("Flavor list sorted by number of Allergens");
            foreach(Flavor flavor in availableFlavors)
            {
                Console.WriteLine(flavor);
            }
            Console.WriteLine("\nCone list sorted by Cost");
            foreach (Cone cone in availableCones)
            {
                Console.WriteLine(cone);
            }

        }
    }
}
