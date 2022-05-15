using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Visitor
{
    public interface IVisitor
    {
        void Visit(Manager manager);
        void Visit(Worker manager);
    }
}
