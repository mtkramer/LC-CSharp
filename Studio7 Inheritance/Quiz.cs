using System;
using System.Collections.Generic;
using System.Text;

namespace Studio7_Inheritance
{
    class Quiz
    {
        private uint Number { get; set; } = 1;
        private readonly Dictionary<uint, Question> Questions;
        private readonly Dictionary<uint, string> Answers;
        
        public Quiz() { }

        public void AddQ()
        {
            Console.Write("Add question text: ");
            string text = Console.ReadLine();
            Console.Write("Choose question type: 1.) Multiple Choice  2.) Checkbox  3.) True or False: ");
            int type = int.Parse(Console.ReadLine());
            
            if(type == 1)
            {
                string[] choices = new string[4];
                for (uint i=1; i<5; i++)
                {
                    Console.Write($"Answer choice {i}: ");
                    choices[i - 1] = Console.ReadLine();
                }
                MultipleChoice m = new MultipleChoice(text, choices);
                Questions.Add(Number, m);
            }
            else if(type == 2) { 
                
            }
            else { }
            Console.Write("Add correct answers: ");
            string input = Console.ReadLine().ToUpper();
            Answers.Add(Number, input);
            Number++;
        }

    }
}
//  $"______________________________\nQuestion #{id}\n{text}?\n\n";
//  template += "Enter your answer: ";