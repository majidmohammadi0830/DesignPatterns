using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Specification
{
    public class TeacherWhoHasMoreThan10YearsExperienceSpecification : CompositeSpecification<Teacher>
    {
        public override bool IsSatisfiedBy(Teacher entity)
        {
            return entity.TeachingExperience > 10;
        }
    }
}
