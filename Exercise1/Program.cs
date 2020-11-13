using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank," +
                " and of having nothing to do: once or twice she had peeped into the book her sister was reading," +
                " but it had no pictures or conversations in it,'and what is the use of a book,' thought Alice" +
                " 'without pictures or conversation?'";

            Console.WriteLine("Search for?");
            string searchTerm = Console.ReadLine().ToLower();
            if (sentence.ToLower().Contains(searchTerm))
            {
                int start = sentence.ToLower().IndexOf(searchTerm);
                int len = searchTerm.Length;
                Console.Write("Word was found at index: " + start + ", ");
                Console.WriteLine("with length of " + len);
                Console.WriteLine(sentence.Remove(start, len));
            }
        }
    }
}

/*
Extend the previous exercise. Assume the user enters a word that is in the sentence. 
Print out its index within the string and its length. Next, remove the word from the string and print the sentence again to
confirm your code. Remember that strings are immutable, so you will need to reassign the old sentence variable or create a 
new one to store the updated phrase
*/