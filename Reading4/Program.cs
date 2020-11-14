using System;

namespace Reading4
{
    class Program
    {
        static void Main(string[] args)
        {
            Greet g = new Greet();
            g.Message = "Hello, Mike!";
            g.Display();
            Console.WriteLine(g.Message);
        }

        public class Greet
        {
            public string Message { get; set; } = "Hello, World!";
            public Greet(string message)
            {
                Message = message;
            }
            public Greet() { }
            public void Display()
            {
                Console.WriteLine(Message);
            }

        }
    }
}
