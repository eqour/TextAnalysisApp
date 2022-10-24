using System.Text;
using System.IO;

namespace TextAnalysisApp.Utils
{
    public class TextFileReader
    {
        public static string ReadFile(string fileName)
        {
            return File.ReadAllText(fileName, Encoding.UTF8);
        }
    }
}
