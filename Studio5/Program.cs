using System;

namespace Studio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime now = DateTime.Now;
            // Console.WriteLine($"Ticks: {now.Ticks}");
            Menu menu = new Menu();
            MenuItem steak = new MenuItem("Seasoned, seared, and served the way you want.", 18, 1);
            menu.AddMenuItem("Steak", steak);
            MenuItem wings = new MenuItem("Hot, sweet, and chewy.", 9, 0);
            menu.AddMenuItem("Buffalo Wings", wings);
            MenuItem brownie = new MenuItem("With chocolate chips and a scoop of vanilla ice cream.", 9, 2);
            menu.AddMenuItem("Chocolate Brownie", brownie);
            menu.AddMenuItem("Chocolate Brownie", brownie);
            MenuItem brown = new MenuItem("With chocolate chips and a scoop of vanilla ice cream.", 9, 2);
            menu.AddMenuItem("Brown", brown);
            MenuItem cake = new MenuItem("With chocolate chips and a scoop of vanilla ice cream.", 11, 2);
            menu.AddMenuItem("Chocolate Cake", cake);
            menu.PrintMenu();
        }
    }
}
