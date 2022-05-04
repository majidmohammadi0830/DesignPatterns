using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Specification
{
    public class StudentWhoIsOver16YearsOldSpecification : CompositeSpecification<Student>
    {
        public override bool IsSatisfiedBy(Student entity)
        {
            return entity.BirthDate < DateTime.Now.AddYears(-16);
        }
    }
}
