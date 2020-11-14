using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
            // ARRAY PRACTICE
            //Create and initialize an array with the following values in a single line: 1, 1, 2, 3, 5, 8
            int[] arr = { 1, 1, 2, 3, 5, 8 };

            //Loop through the array and print out each value.
            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }

            //Modify the loop to only print the odd numbers from the array.
            foreach(int item in arr)
            {
                if(!(item % 2 == 0))
                {
                    Console.WriteLine(item);
                }
            }
            */

            /*
            // STRING PRACTICE
            //For this exercise, create a string for the value:
            string str = "I would not, could not, in a box. " +
                "I would not, could not with a fox. " +
                "I will not eat them in a house. " +
                "I will not eat them with a mouse. ";
            Console.WriteLine("Old Passage:\n{0}", str);

            //Use the Split method to divide the string at each space and store the individual words in an array.
            string[] arr = str.Split(' ');

            //Print the array of words to verify that your code works.
            Console.Write("[");
            foreach(string word in arr)
            {
                Console.Write("\"{0}\", ", word);
            }
            Console.WriteLine("]");

            //Repeat steps 2 and 3, but change the delimiter to split the string into separate sentences.
            arr = str.Split(". ");
            Console.Write("[");
            foreach (string sentence in arr)
            {
                Console.Write("\"{0}\", ", sentence);
            }
            Console.WriteLine("]");
            */

            //LIST PRACTICE
            //Within Main, create a list with at least 10 integers and call your method on the list.
            //Update your solution to use the string from the Array Practice section.
            List<int> nums = new List<int>{ 7,9,8,4,3,1,6,8,7,6,1,3 };  // 7+9+3+1+7+1+3=31
            Evener(nums);
            List<string> words = new List<string> { "word", "five", "seven", "peeps", "the" };  // "seven", "peeps"
            WordFinder(words);
            string str = "I would not, could not, in a box. " +
                "I would not, could not with a fox. " +
                "I will not eat them in a house. " +
                "I will not eat them with a mouse. ";
            string[] arr = str.Trim().Split(' ');
            for(int i = 0; i < arr.Length; i++)
            {
                int lastIndex = (arr[i]).Length - 1;
                char last = (arr[i])[lastIndex];
                switch(last)
                {
                    case ',': arr[i] = arr[i].Remove(lastIndex); break;
                    case '.': arr[i] = arr[i].Remove(lastIndex); break;
                    default: break;
                }
            }
            words = new List<string>(arr);
            WordFinder(words);
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
        }

        // LIST PRACTICE
        //Write a static method to find the sum of all the even numbers in a List.
        static void Evener(List<int> list)
        {
            int sum = 0;
            foreach(int num in list) { if (!(num % 2 == 0)) { sum += num; } }
            Console.WriteLine("Sum: {0}", sum);
        }

        //Write a static method to print out each word in a list that has exactly 5 letters.
        //Modify your code to prompt the user to enter the word length for the search
        static void WordFinder(List<string> list)
        {
            Console.Write("How many letters? ");
            int num = int.Parse(Console.ReadLine());
            foreach(string word in list)
            {
                if (word.Length == num) {
                    Console.WriteLine(word);
                }
            }
        }


    }
}
