namespace _03.Visitor
{
    public class MonthlySalary : Salary
    {
        public MonthlySalary(decimal amount, Month month) : base(amount, month)
        {
            SalaryType = SalaryType.MonthlySalary;
        }
    }

}
