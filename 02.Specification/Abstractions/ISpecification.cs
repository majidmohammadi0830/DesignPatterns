using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Specification
{
   public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T entity);
    }
}
