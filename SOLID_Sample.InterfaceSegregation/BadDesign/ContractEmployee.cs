namespace SOLID_Sample.InterfaceSegregation;
public class ContractEmployee : IWorker
{
    #region prop
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public float MonthlySalary { get; set; }
    public float OtherBenefits { get; set; }
    public float HourlyRate { get; set; }
    public float HoursInMonth { get; set; }
    #endregion

    public float CalaculateWorkedSalary() => throw new NotImplementedException();

    public float CalculateNetSalary() => HourlyRate * HoursInMonth;
}
