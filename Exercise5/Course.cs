using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5_Classes_Pt2_Obj
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
