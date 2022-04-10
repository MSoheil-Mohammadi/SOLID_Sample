using System.Text;

namespace SOLID_Sample.LiskovSubstitution.BadDesign;

public class SqlFileManagerV2
{
    public List<SqlFile>? listSqlFiles {get;set;}
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
            // Check whether the current file object is read-only or not.If yes, skip calling it's  
            // SaveText() method to skip the exception.  

            if (objFile is ReadOnlySqlFile)
                objFile.SaveText();
        }
    }  
}  