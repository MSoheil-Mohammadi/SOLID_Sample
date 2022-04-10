using System.Text;

namespace SOLID_Sample.LiskovSubstitution.BadDesign;

public class SqlFileManager
{
    public List<SqlFile> listSqlFiles { get; set; }

    public string GetTextFromFiles()
    {
        StringBuilder objStrBuilder = new StringBuilder();
        foreach (var objFile in listSqlFiles)
        {
            objStrBuilder.Append(objFile.LoadText());
        }
        return objStrBuilder.ToString();
    }
    public void SaveTextIntoFiles()
    {
        foreach (var objFile in listSqlFiles)
        {
            objFile.SaveText();
        }
    }
}
