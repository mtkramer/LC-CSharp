using System;
using System.Text;
using System.Collections.Generic;

namespace Reading3_Collections
{
    class ReadingPractice
    {
        static void Main(string[] args)
        {
            /*
            BuildString str = new BuildString(); 
            str.Build();
            */

            GradeBook gb = new GradeBook();
            gb.NewClass();
            gb.PrintRoster();
        }


        public class GradeBook
        {
            public Dictionary<string, double> Students { get; }

            public GradeBook()
            {
                Students = new Dictionary<string, double>();
            }

            public void NewClass()
            {
                List<string> people = new List<string>();
                string input;
                double grade = -1;
                while (!people.Equals(""))
                {
                    Console.WriteLine("Enter student: (press <Enter> to quit)");
                    input = Console.ReadLine();
                    if (input.Equals("")) { break; }
                    people.Add(input);
                }
                foreach(string student in people) {
                    while (grade < 0 || grade > 150)
                    {
                        Console.WriteLine("Enter a grade for {0}: (enter <0> for no grade)", student);
                        grade = double.Parse(Console.ReadLine());
                    }
                    Students.Add(student, grade);
                    grade = -1;
                }
            }
            
            public void PrintRoster()
            {
                Console.WriteLine("\nClass roster:");
                double sum = 0.0;

                foreach(string student in Students.Keys)
                {
                    double grade = Students[student];
                    Console.WriteLine("Student: {0}, Grade: {1}", student, grade);
                    sum += grade;
                }

                double avg = sum / Students.Count;
                Console.WriteLine("Average grade: {0}%", avg);
            }

        }

        public class BuildString{

            public string[] ArrayOfWords { get; } = { "Books", "Cheese", "Trees", "Laughter" };
            public void Build()
            {
                StringBuilder sb = new StringBuilder();
                foreach (string word in ArrayOfWords)
                {
                    sb.Append(word);
                    sb.Append("+");
                }
                Console.WriteLine(sb);
            }
        }
    }
}
