using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace _02.Specification.Tests
{
    public class StudentTests
    {
        [Fact]
        public void Courses_Should_Not_Be_Null()
        {
            Student student = new Student();
            Assert.NotNull(student.Courses);
        }

        [Fact]
        public void Student_Who_Has_Not_Expired_Mathematics_Course_And_Is_Less_16_Years_Old_Should_Satisfy_Specification()
        {
            Student student = new Student()
            {
                BirthDate = DateTime.Now.AddYears(-15),
            };
            student.Courses.Add(new Course()
            {
                CourseType = CourseType.Mathematics,
                ScheduleDateTime = DateTime.Now.AddMonths(1),
                Title = "Economics Course"
            });
            var specification = new StudentWhoHasNotExpiredMathematicsCourseSpecification()
                                    .And(new StudentWhoIsOver16YearsOldSpecification().Not());
            Assert.True(specification.IsSatisfiedBy(student));
        }
    }
}
