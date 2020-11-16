using System;
using System.Collections.Generic;

namespace Exercise4_Classes_Pt1
{
    class Teacher
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Subject { get; set; }
        public int YearsTeaching { get; set; }

        public Teacher(string fname, string lname, string subject, int years)
        {
            FirstName = fname;
            LastName = lname;
            Subject = subject;
            YearsTeaching = years;
        }
        public Teacher(string fname, string lname, string subject) : this(fname, lname, subject, 0) { }

    }
}
