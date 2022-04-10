namespace SOLID_Sample.DependencyInversoin.GoodDesign;
public interface ISalaryCalculator
{
    public float CalculateSalary(int hoursWorked, float hourlyRate);
}
