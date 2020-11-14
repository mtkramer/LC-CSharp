using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student(name, id, credits, gpa)
            // Teacher(fname, lname, subject, years)
            Student me = new Student("Mike", 22, 51, 4.0);
            Console.WriteLine(me.GetGradeLevel());
            me.AddGrade(3, 0);
            Console.WriteLine(me.Gpa);
        }
    }
}
