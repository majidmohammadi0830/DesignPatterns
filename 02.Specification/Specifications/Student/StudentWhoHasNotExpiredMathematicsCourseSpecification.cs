using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Specification
{
    public class StudentWhoHasNotExpiredMathematicsCourseSpecification : CompositeSpecification<Student>
    {
        public override bool IsSatisfiedBy(Student entity)
        {
            return entity.Courses.Any(c => c.CourseType == CourseType.Mathematics && c.ScheduleDateTime > DateTime.Now);
        }
    }
}
