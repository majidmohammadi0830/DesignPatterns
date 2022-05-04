using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Composite
{
    public class Manager : Employee
    {
        public Manager(List<Employee> employees)
        {
            SubEmployees = employees;
        }
        public List<Employee> SubEmployees { get; private set; }
        public override void PaySalary(Salary salary)
        {
            switch (salary.SalaryType)
            {
                case SalaryType.MonthlySalary:
                    SalaryHistory.Add(salary);
                    break;
                case SalaryType.AnnualBonus:
                    {
                        decimal annualBonusAmount = salary.Amount - (salary.Amount * (decimal)0.5);
                        AnnualBonus annualBonus = (AnnualBonus)salary.Clone(annualBonusAmount);
                        SalaryHistory.Add(annualBonus);
                        foreach (Employee employee in SubEmployees)
                        {
                            AnnualBonus subEmployeeAnnualBonuse = (AnnualBonus)salary.Clone(annualBonusAmount / SubEmployees.Count);
                            employee.PaySalary(subEmployeeAnnualBonuse);
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
