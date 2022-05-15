using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Visitor
{
    public class Worker : Employee
    {
        public Worker()
        {
        }

        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
