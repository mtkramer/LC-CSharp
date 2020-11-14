using System;
using System.Collections.Generic;

namespace Studio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //write a program to count the number of times each character occurs in a string and then print the results to the console
            string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. " +
                "Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. " +
                "Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            Counter counter1 = new Counter();
            counter1.Count(str);
            Counter counter2 = new Counter();
            Console.WriteLine("Please enter a string to be counted below.");
            str = Console.ReadLine();
            counter2.Count(str);
            str = System.IO.File.ReadAllText(@"C:\Users\theos\OneDrive\Desktop\LC-CSharp\Studio3\TextFile.txt");
            Counter counter3 = new Counter();
            counter3.Count(str);
        }

        public class Counter
        {
            public Dictionary<string, int> Buckets { get; } = new Dictionary<string, int>();
        public void Count(string str)
            {
                char[] data = str.ToLower().ToCharArray();


                foreach(char c in data)
                {
                    if( Equals(c, ',') || Equals(c, '.') || Equals(c, ' ') ) { continue; }
                    string key = c + "";
                    if (!Buckets.ContainsKey(key)) {
                        Buckets.Add(key, 1);
                    } else {
                        Buckets[key]++;
                    }   
                }
                foreach(string key in Buckets.Keys)
                {
                    Console.WriteLine($"{key}: {Buckets[key]}");
                }
            }

        }
    }
}
