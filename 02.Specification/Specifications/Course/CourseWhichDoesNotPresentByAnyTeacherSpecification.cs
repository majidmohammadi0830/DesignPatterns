using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Specification
{
    public class CourseWhichDoesNotPresentByAnyTeacherSpecification : CompositeSpecification<Course>
    {
        public override bool IsSatisfiedBy(Course entity)
        {
            return entity.Teachers.Count == 0;
        }
    }
}
