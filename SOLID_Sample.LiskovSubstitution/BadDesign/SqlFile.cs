namespace SOLID_Sample.LiskovSubstitution.BadDesign;
public class SqlFile
{
    #region prop
    public string FilePath { get; set; }
    public string FileText { get; set; } 
    #endregion
    public string LoadText()
    {
        /* Code to read text from sql file */
        return nameof(LoadText);
    }
    public string SaveText()
    {
        /* Code to save text into sql file */
        return nameof(SaveText);
    }
}
