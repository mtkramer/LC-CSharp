﻿
namespace Studio7_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // MultipleChoice: text: "Which coding language is your favorite?", "Java", "C#", "JavaScrip", "Pyton"
            // CheckBox: text: "Which coding languages are used by the browser?", "JavaScript", "CSS", "XML", "Rust", "Ruby", "HTML"
            // TrueFalse: text: "Coding is easy?", "True"

            Quiz q = new Quiz();
            q.AddPair(
                new MultipleChoice(
                    "Which coding language is your favorite?", 
                    new string[] { "Java", "C#", "JavaScrip", "Pyton" }
                ), 
                new char[] { 'B' }
            );
            q.AddPair(
                new CheckBox(
                    "Which coding languages are used by the browser?",
                    new string[] { "JavaScript", "CSS", "XML", "Rust", "Ruby", "HTML" }
                ),
                new char[] { 'A', 'B', 'F' }
            );
            q.AddPair(new TrueFalse("Coding is easy?"), new char[] { 'T' });

            q.StartQuiz();
            q.GradeQuiz();

        }   
    }
}
