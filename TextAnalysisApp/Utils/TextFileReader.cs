using System.Text;

namespace TextAnalysisApp.Utils
{
    /// <summary>
    /// Содержит функционал для чтения данных из файлов
    /// </summary>
    public class TextFileReader
    {
        /// <summary>
        /// Открывает файл для чтения, читает всё содержимое файла и закрывает файл
        /// </summary>
        /// <param name="fileName">Путь к файлу</param>
        /// <returns>Строка, содержащая весь текст в файле</returns>
        public static string ReadFile(string fileName)
        {
            return File.ReadAllText(fileName, Encoding.UTF8);
        }
    }
}
