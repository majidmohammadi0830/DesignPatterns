using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Specification
{
    public class ExpiredCourseSpecification : CompositeSpecification<Course>
    {
        public override bool IsSatisfiedBy(Course entity)
        {
            return entity.ScheduleDateTime < DateTime.Now;
        }
    }
}
