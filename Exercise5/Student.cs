using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        private readonly int studentId;
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int sId, int numberOfCredits, double gpa)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int sId)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public Student(string name)
        {
            Name = name;
            studentId = nextStudentId;
            nextStudentId++;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public string StudentInfo()
        {
            return (Name + " has a GPA of: " + Gpa);
        }

        public void AddGrade(int courseCredits, double grade)
        {
            double totalScore = NumberOfCredits * Gpa + courseCredits * grade;
            NumberOfCredits += courseCredits;
            Gpa = totalScore / NumberOfCredits;
        }

        public string GetGradeLevel()
        {
            if (NumberOfCredits > 0 && NumberOfCredits < 30) { return "Freshman"; }
            else if (NumberOfCredits < 60) { return "Sophomore"; }
            else if (NumberOfCredits < 90) { return "Junior"; }
            else if (NumberOfCredits > 89) { return "Senior"; }
            else { return "Invalid number of credits"; }
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                Name == student.Name &&
                studentId == student.studentId &&
                NumberOfCredits == student.NumberOfCredits &&
                Gpa == student.Gpa;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, studentId);
        }
    }
}
