namespace SOLID_Sample.InterfaceSegregation.GoodDesign;
public interface IContractWorkerSalary : IBaseWorker
{
    #region Special prop's
    public float HourlyRate { get; set; }
    public float HoursInMonth { get; set; }
    #endregion

    public float CalaculateWorkedSalary();
}
