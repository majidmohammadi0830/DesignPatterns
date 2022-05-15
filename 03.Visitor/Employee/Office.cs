using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Visitor
{
    public class Office
    {
        private List<Employee> _employees;
        public Office()
        {
            _employees = new List<Employee>();
        }

        public void Attach(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Detach(Employee employee)
        {
            _employees.Remove(employee);
        }

        public void AcceptVisitor(IVisitor visitor)
        {
            foreach (var employee in _employees)
            {
                employee.AcceptVisitor(visitor);
            }
        }

        public List<Employee> GetEmployees() => _employees;
    }
}
