using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Specification
{
    public class NotSpecification<T> : CompositeSpecification<T>
    {
        private readonly ISpecification<T> specification;

        public NotSpecification(ISpecification<T> specification)
        {
            this.specification = specification;
        }
        public override bool IsSatisfiedBy(T entity)
        {
            return !specification.IsSatisfiedBy(entity);
        }
    }
}
