using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Specification
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        public CompositeSpecification<T> And(ISpecification<T> right)
        {
            return new AndSpecification<T>(this, right);
        }
        public CompositeSpecification<T> Or(ISpecification<T> right)
        {
            return new OrSpecification<T>(this, right);
        }
        public CompositeSpecification<T> Not()
        {
            return new NotSpecification<T>(this);
        }
        public abstract bool IsSatisfiedBy(T entity);
    }
}
