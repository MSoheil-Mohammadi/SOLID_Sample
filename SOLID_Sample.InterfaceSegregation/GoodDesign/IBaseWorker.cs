namespace SOLID_Sample.InterfaceSegregation.GoodDesign;
public interface IBaseWorker
{
    #region Base prop's
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    #endregion
}
