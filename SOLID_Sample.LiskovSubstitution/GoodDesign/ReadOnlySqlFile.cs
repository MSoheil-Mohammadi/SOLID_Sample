namespace SOLID_Sample.LiskovSubstitution.GoodDesign;
public class ReadOnlySqlFile : IReadableSqlFile
{
    public string FilePath { get; set; }
    public string FileText { get; set; }
    public string LoadText()
    {
        /* Code to read text from sql file */
        return nameof(LoadText);
    }
}
