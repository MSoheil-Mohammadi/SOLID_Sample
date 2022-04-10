namespace SOLID_Sample.InterfaceSegregation.GoodDesign;
public class FullTimeEmployeeFixed : IFullTimeWorkerSalary
{
    public float MonthlySalary { get; set; }
    public float OtherBenefits { get; set; }
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public float CalculateNetSalary() => MonthlySalary + OtherBenefits;
}
