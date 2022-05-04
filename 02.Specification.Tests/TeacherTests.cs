using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace _02.Specification.Tests
{
    public class TeacherTests
    {

        [Fact]
        public void Courses_Should_Not_Be_Null()
        {
            Teacher teacher = new Teacher();
            Assert.NotNull(teacher.Courses);
        }

        [Fact]
        public void Has_More_Than_10Years_Experience_Or_DoesNot_Have_Any_Course_Should_Satisfy_Specification()
        {
            Teacher teacher = new Teacher()
            {
                TeachingExperience = 12,
            };
            var specification = new TeacherWhoHasMoreThan10YearsExperienceSpecification()
                                    .Or(new TeacherWhoDoesNotHaveAnyCourseSpecification());
            Assert.True(specification.IsSatisfiedBy(teacher));
        }
    }
}
