namespace SOLID_Sample.DependencyInversoin.GoodDesign;
public class EmployeeDetailsModified
{
    private readonly ISalaryCalculator salaryCalculator;
    #region prop
    public int HoursWorked { get; set; }
    public int HourlyRate { get; set; }
    #endregion

    public EmployeeDetailsModified(ISalaryCalculator salaryCalculator)
    {
        this.salaryCalculator = salaryCalculator;
    }

    public float GetSalary()
    {
        return salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
    }
}
