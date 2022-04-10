namespace SOLID_Sample.InterfaceSegregation.GoodDesign;
public class ContractEmployeeFixed : IContractWorkerSalary
{
    public float HourlyRate { get; set; }
    public float HoursInMonth { get; set; }
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public float CalaculateWorkedSalary() => HourlyRate * HoursInMonth;
}
