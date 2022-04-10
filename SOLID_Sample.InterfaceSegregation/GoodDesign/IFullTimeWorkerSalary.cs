namespace SOLID_Sample.InterfaceSegregation.GoodDesign;
public interface IFullTimeWorkerSalary : IBaseWorker
{
    #region Special prop's
    public float MonthlySalary { get; set; }
    public float OtherBenefits { get; set; }
    #endregion

    public float CalculateNetSalary();
}
