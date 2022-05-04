using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Specification
{
    public class OrSpecification<T> : CompositeSpecification<T>
    {
        private readonly ISpecification<T> left;
        private readonly ISpecification<T> right;
        public OrSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            this.left = left;
            this.right = right;
        }
        public override bool IsSatisfiedBy(T entity)
        {
            return left.IsSatisfiedBy(entity) || right.IsSatisfiedBy(entity);
        }
    }
}
