using System;

namespace Studio8_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            DVD dvd = new DVD();
            CD cd = new CD();

            dvd.PlayDisc();
            dvd.LoadDisc();
            dvd.WriteData("Waterworld", 200);
            dvd.PlayDisc();
            dvd.WriteData("Batman Begins", 95);
            dvd.PlayDisc();

            Console.WriteLine("\n\n");

            cd.PlayDisc();
            cd.LoadDisc();
            cd.WriteData("The Hobbit", 200);
            cd.PlayDisc();
            cd.WriteData("Cyberpunk Mix", 90);
            cd.PlayDisc();
        }
    }
}
