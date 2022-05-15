using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _03.Visitor
{
    public class PerformanceBonusVisitor : IVisitor
    {
        private readonly Month month;

        public PerformanceBonusVisitor(Month month)
        {
            this.month = month;
        }

        public void Visit(Manager manager)
        {
            var currentMonthSalary = (MonthlySalary)manager.SalaryHistory.FirstOrDefault(s => s is MonthlySalary salary && salary.Month == month);
            if (currentMonthSalary == null)
                throw new Exception("Current month's salary has not been paid yet!");
            manager.SalaryHistory.Add(new PerformanceBonus(currentMonthSalary.Amount * (decimal)0.5, month));
        }

        public void Visit(Worker manager)
        {
            manager.SalaryHistory.Add(new PerformanceBonus(1000, month));
        }
    }
}
