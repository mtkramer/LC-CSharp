using System;
using System.Collections.Generic;

namespace Exercise4_Classes_Pt1
{
    class Course
    {
        public string Teacher { get; set; }
        public int Credits { get; set; }
        public List<Student> Students { get; set; }

        public Course(string teacher, int credits)
        {
            Teacher = teacher;
            Credits = credits;
            Students = new List<Student>();
        }

    }
}
