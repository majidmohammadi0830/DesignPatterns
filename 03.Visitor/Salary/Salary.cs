using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Visitor
{
    public abstract class Salary
    {
        public Salary(decimal amount,Month month)
        {
            Month = month;
            Amount = amount;
            PayDate = DateTime.Now;
        }

        public Month Month { get; private set; }
        public SalaryType SalaryType { get; protected set; }
        public DateTime PayDate { get; private set; }
        public int Year => PayDate.Year;
        public decimal Amount { get; private set; }
    }

}
