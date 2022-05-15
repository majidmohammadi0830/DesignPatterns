using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Visitor
{
    public class PerformanceBonus : Salary
    {
        public PerformanceBonus(decimal amount, Month month) : base(amount, month)
        {
            SalaryType = SalaryType.PerformanceBonus;
        }

    }
}
