using System.Text;

namespace SOLID_Sample.LiskovSubstitution.GoodDesign;

public class SqlFileManager
{
    public string GetTextFromFiles(List<IReadableSqlFile> aLstReadableFiles)
    {
        StringBuilder objStrBuilder = new StringBuilder();
        foreach (var objFile in aLstReadableFiles)
        {
            objStrBuilder.Append(objFile.LoadText());
        }
        return objStrBuilder.ToString();
    }
    public void SaveTextIntoFiles(List<IWritableSqlFile> aLstWritableFiles)
    {
        foreach (var objFile in aLstWritableFiles)
        {
            objFile.SaveText();
        }
    }
}