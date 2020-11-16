using System;

namespace Studio4_Classes_Pt1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"Ticks: {now.Ticks}");
        }
    }
}
/*
The app should know when the menu was last updated, so visitors can see that the restaurant is constantly changing and
adding exciting new items
 */