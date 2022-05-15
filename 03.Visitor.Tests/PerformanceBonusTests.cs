using System;
using System.Linq;
using Xunit;

namespace _03.Visitor.Tests
{
    public class PerformanceBonusTests
    {
        [Fact]
        public void Null_Value_Of_Manager_Current_Month_Salary_ThrowsException()
        {
            Manager manager = new Manager();

            Office office = new Office();
            office.Attach(manager);

            PerformanceBonusVisitor performanceBonusVisitor = new PerformanceBonusVisitor(Month.May);

            Assert.Throws<Exception>(()=> office.AcceptVisitor(performanceBonusVisitor));
        }

        [Fact]
        public void Should_Be_Paid_To_Manager_Based_On_Half_Of_Current_Month_Salary()
        {
            Manager manager = new Manager();
            manager.SalaryHistory.Add(new MonthlySalary(1000, Month.May));

            Office office = new Office();
            office.Attach(manager);

            PerformanceBonusVisitor performanceBonusVisitor = new PerformanceBonusVisitor(Month.May);
            office.AcceptVisitor(performanceBonusVisitor);

            PerformanceBonus performanceBonus = (PerformanceBonus)manager.SalaryHistory.LastOrDefault();
            Assert.Equal(500, performanceBonus.Amount);
        }

        [Fact]
        public void Should_Be_Paid_1000_To_Worker()
        {
            Worker manager = new Worker();

            Office office = new Office();
            office.Attach(manager);

            PerformanceBonusVisitor performanceBonusVisitor = new PerformanceBonusVisitor(Month.May);
            office.AcceptVisitor(performanceBonusVisitor);

            PerformanceBonus performanceBonus = (PerformanceBonus)manager.SalaryHistory.LastOrDefault();
            Assert.Equal(1000, performanceBonus.Amount);
        }

    }
}
