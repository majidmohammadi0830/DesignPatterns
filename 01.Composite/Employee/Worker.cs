using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Composite
{
    public class Worker : Employee
    {
        public override void PaySalary(Salary salary)
        {
            SalaryHistory.Add(salary);
        }
    }
}
