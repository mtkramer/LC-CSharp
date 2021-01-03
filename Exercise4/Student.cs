namespace Exercise4
{
    public class Student
    {
        public string Name { get; }
        public int StudentId { get; }
        public int NumberOfCredits { get; private set; }
        public double Gpa { get; private set; }

        public Student(string name, int id, int credits, double gpa)
        {
            Name = name;
            StudentId = id;
            NumberOfCredits = credits;
            Gpa = gpa;
        }
    }
}
