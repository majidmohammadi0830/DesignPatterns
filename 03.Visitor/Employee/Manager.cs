using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Visitor
{
    public class Manager : Employee
    {
        public Manager()
        {
        }

        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
