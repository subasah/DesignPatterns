using System.Text;
using System.Text.RegularExpressions;

namespace TextToHtmlConvertor;

public class FileProcessor
{
    private readonly string fullFilePath;
    
    public FileProcessor(string fullFilePath)
    {
        this.fullFilePath = fullFilePath;
    }
    public string ReadAllText()
    {
        return System.Web.HttpUtility.HtmlEncode(File.ReadAllText(fullFilePath));
    }
    public void WriteToFile(string text)
    {
        var outputFilePath = Path.GetFileNameWithoutExtension(fullFilePath)+".html";
        using var file = new StreamWriter(outputFilePath);
        file.Write(text);
    }
}
