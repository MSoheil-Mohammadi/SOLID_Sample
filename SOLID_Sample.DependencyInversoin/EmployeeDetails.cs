namespace SOLID_Sample.DependencyInversoin;
public class EmployeeDetails
{
    public int HoursWorked { get; set; }
    public int HourlyRate { get; set; }

    public float GetSalary()
    {
        SalaryCalculator salaryCalculator = new();
        return salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
    }
}

public class SalaryCalculator
{
    public float CalculateSalary(int hoursWorked, float hourlyRate) => hoursWorked * hourlyRate;
}
