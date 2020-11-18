using System;
using System.Collections.Generic;
using System.Text;

namespace Studio7_Inheritance
{
    class Quiz
    {
        private uint IdNumber { get; set; } = 1;
        private readonly Dictionary<uint, Question> Questions;
        private readonly Dictionary<uint, string[]> Answers;
        
        public Quiz() 
        { 
            Questions = new Dictionary<uint, Question>();
            Answers = new Dictionary<uint, string[]>();
        }

        public void AddPair(Question question, string[] answer)
        {
            Questions.Add(IdNumber, question);
            Answers.Add(IdNumber, answer);
            IdNumber++;
        }

        public void StartQuiz()
        {
            foreach (uint key in Questions.Keys)
            {
                Console.WriteLine("____________________");
                Console.WriteLine($"Question: #{key}");
                Questions[key].Ask();
            }
        }

        public void GradeQuiz()
        {

        }

    }
}
