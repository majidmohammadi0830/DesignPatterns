using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace _01.Composite.Tests
{
    public class ManagerTests
    {
        [Fact]
        public void SalaryHistory_Should_NotBe_Null()
        {
            Employee worker = new Manager(new List<Employee>());
            Assert.NotNull(worker.SalaryHistory);
        }

        [Fact]
        public void Monthly_Salary_Value_Should_Add_To_Total_SalaryHistory()
        {
            Employee manager = new Manager(new List<Employee>());
            manager.PaySalary(new MonthlySalary(2000));
            manager.PaySalary(new MonthlySalary(2500));
            Assert.Equal(4500, manager.SalaryHistory.Sum(s => s.Amount));
        }

        [Fact]
        public void Half_Of_Annual_Reward_Should_Be_Paid_To_ThemSelves()
        {
            Manager manager = new Manager(new List<Employee>());
            manager.PaySalary(new AnnualBonus(1000));
            Assert.Equal(500, manager.SalaryHistory.Sum(s => s.Amount));
        }

        [Fact]
        public void Remain_Of_Annual_Reward_Should_Be_Paid_To_Their_SubEmployees()
        {
            //                            Manager
            // Employees :      Worker1             Manager1
            // Employees1:                          Woker1_1
            //  
            List<Employee> employees = new List<Employee>();
            Worker worker1 = new Worker();
            employees.Add(worker1);
            List<Employee> employees1 = new List<Employee>();
            Worker worker1_1 = new Worker();
            employees1.Add(worker1_1);
            Manager manager1 = new Manager(employees1);
            employees.Add(manager1);
            Manager manager = new Manager(employees);
            manager.PaySalary(new AnnualBonus(1000));
            Assert.Equal(500, manager.SalaryHistory.Sum(s => s.Amount));
            Assert.Equal(250, worker1.SalaryHistory.Sum(s => s.Amount));
            Assert.Equal(125, manager1.SalaryHistory.Sum(s => s.Amount));
            Assert.Equal(125, worker1_1.SalaryHistory.Sum(s => s.Amount));
        }


    }
}
