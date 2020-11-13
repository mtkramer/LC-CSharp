using System;
using System.Text;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfWords = { "Books", "Cheese", "Trees", "Laughter" };
            StringBuilder sb = new StringBuilder();
            foreach (string word in arrayOfWords)
            {
                sb.Append(word);
            }
            Console.WriteLine(sb);
        }
    }
}
