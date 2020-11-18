using System;
using System.Collections.Generic;

namespace Studio7_Inheritance
{
    class Quiz
    {
        private uint IdNumber { get; set; } = 1;
        private readonly Dictionary<uint, Question> Questions;
        private readonly Dictionary<uint, char[]> Answers;
        
        public Quiz() 
        { 
            Questions = new Dictionary<uint, Question>();
            Answers = new Dictionary<uint, char[]>();
        }

        public void AddPair(Question question, char[] answer)
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
            int total = Questions.Count;
            double correct = 0;
            foreach (uint key in Questions.Keys)
            {
                Type t = Questions[key].GetType();
                if (t == typeof(CheckBox))
                {
                    total += Answers[key].Length - 1;
                    foreach (char answer in Answers[key])
                    {
                        foreach (char response in Questions[key].Response)
                        {
                            if (response == answer)
                            {
                                correct++;
                                Console.WriteLine($"Checkbox correct: {correct}");
                                break;
                            }
                        }
                    }
                }
                else
                {
                    foreach (char answer in Answers[key])
                    {
                        if (Questions[key].Response[0] == answer)
                        {
                            correct++;
                            Console.WriteLine($"Non-CheckBox correct: {correct}");
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(
                $"********************\n" +
                $"# Questions: {total}\n" +
                $"# Correct: {correct}\n" +
                $"Percent correct: {correct / total}"
            );
        }

    }
}
