using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Specification
{
    public class TeacherWhoDoesNotHaveAnyCourseSpecification : CompositeSpecification<Teacher>
    {
        public override bool IsSatisfiedBy(Teacher entity)
        {
            return entity.Courses.Count == 0;
        }
    }
}
