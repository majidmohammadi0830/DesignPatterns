namespace _01.Composite
{
    public class AnnualBonus : Salary
    {
        public AnnualBonus(decimal amount) : base(amount)
        {
            SalaryType = SalaryType.AnnualBonus;
        }
    }

}
