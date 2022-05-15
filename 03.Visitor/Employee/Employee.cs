using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Visitor
{
    public abstract class Employee 
    {
        public Employee()
        {
            SalaryHistory = new List<Salary>();
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RecruitDate { get; set; }
        public int IdentificationNumber { get; set; }

        public abstract void AcceptVisitor(IVisitor visitor);

        public ICollection<Salary> SalaryHistory { get; private set; }
    }
}
