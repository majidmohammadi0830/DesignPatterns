using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Composite
{
    public abstract class Salary
    {
        public Salary(decimal amount)
        {
            Amount = amount;
            PayDate = DateTime.Now;
        }
        public SalaryType SalaryType { get; protected set; }
        public DateTime PayDate { get; private set; }
        public decimal Amount { get; private set; }

        public Salary Clone(decimal amount)
        {
            return SalaryType switch
            {
                SalaryType.MonthlySalary => new MonthlySalary(amount),
                SalaryType.AnnualBonus => new AnnualBonus(amount),
                _ => null,
            };
        }
    }

}
