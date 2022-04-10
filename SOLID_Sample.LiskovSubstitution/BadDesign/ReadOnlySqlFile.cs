namespace SOLID_Sample.LiskovSubstitution.BadDesign;

public class ReadOnlySqlFile : SqlFile
{
    public string FilePath { get; set; }
    public string FileText { get; set; }
    public string LoadText()
    {
        /* Code to read text from sql file */
        return base.LoadText();
    }
    public void SaveText()
    {
        /* Throw an exception when app flow tries to do save. */
        throw new IOException("Can't Save");
    }
}