using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Specification
{
    public class Course
    {
        public Course()
        {
            Id = Guid.NewGuid();
            Teachers = new List<Teacher>();
            Students = new List<Student>();
        }
        public Guid Id { get; private set; }
        public CourseType CourseType { get; set; }
        public string Title { get; set; }
        public DateTime ScheduleDateTime { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }
    }

    public enum CourseType
    {
        Economics,
        Geography,
        Mathematics,
        Physics,
    }
}
