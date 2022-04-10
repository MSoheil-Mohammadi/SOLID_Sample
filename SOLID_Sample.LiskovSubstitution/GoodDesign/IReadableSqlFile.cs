namespace SOLID_Sample.LiskovSubstitution.GoodDesign;
public interface IReadableSqlFile
{
    string LoadText();
}
public interface IWritableSqlFile
{
    void SaveText();
}
