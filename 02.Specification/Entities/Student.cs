using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Specification
{
    public class Student : Person
    {
        public Student() : base()
        {
            Courses = new List<Course>();
        }
        public List<Course> Courses { get; set; }
    }
}
