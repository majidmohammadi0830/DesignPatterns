namespace _01.Composite
{
    public class MonthlySalary : Salary
    {
        public MonthlySalary(decimal amount) : base(amount)
        {
            SalaryType = SalaryType.MonthlySalary;
        }
    }

}
