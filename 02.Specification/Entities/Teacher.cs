using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Specification
{
    public class Teacher : Person
    {
        public Teacher() : base()
        {
            Courses = new List<Course>();
        }

        public int TeachingExperience { get; set; }
        public List<Course> Courses { get; set; }
    }
}
