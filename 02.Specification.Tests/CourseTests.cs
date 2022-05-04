using System;
using Xunit;

namespace _02.Specification.Tests
{
    public class CourseTests
    {
        [Fact]
        public void Teachers_Should_Not_Be_Null()
        {
            Course course = new Course();
            Assert.NotNull(course.Teachers);
        }

        [Fact]
        public void Students_Should_Not_Be_Null()
        {
            Course course = new Course();
            Assert.NotNull(course.Students);
        }

        [Fact]
        public void Expired_Mathematics_Course_Which_Has_Not_Been_Presented_By_Any_Teacher_Should_Satisfy_All_Course_Specifications()
        {
            Course course = new Course()
            {
                ScheduleDateTime = DateTime.Now.AddDays(-1),
                Title = "Mathematics Course",
                CourseType = CourseType.Mathematics,
            };
            var specification = new CourseWhichDoesNotPresentByAnyTeacherSpecification()
                                    .And(new ExpiredCourseSpecification())
                                    .And(new MathematicsCourseSpecification());
            Assert.True(specification.IsSatisfiedBy(course));
        }
    }
}
