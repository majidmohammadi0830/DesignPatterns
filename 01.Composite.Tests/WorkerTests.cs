using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace _01.Composite.Tests
{
    public class WorkerTests
    {
        [Fact]
        public void SalaryHistory_Should_NotBe_Null()
        {
            Employee worker = new Worker();
            Assert.NotNull(worker.SalaryHistory);
        }

        [Fact]
        public void Salary_Value_Should_Add_To_Total_SalaryHistory()
        {
            Employee worker = new Worker();
            worker.PaySalary(new MonthlySalary(1000));
            worker.PaySalary(new MonthlySalary(1200));
            worker.PaySalary(new AnnualBonus(2000));
            Assert.Equal(4200, worker.SalaryHistory.Sum(s => s.Amount));
        }
    }
}
