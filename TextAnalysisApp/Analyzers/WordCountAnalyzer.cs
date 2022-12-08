using TextAnalysisApp.Model;
using TextAnalysisApp.Utils;

namespace TextAnalysisApp.Analyzers
{
    /// <summary>
    /// Анализатор, выполняющий подсчёт слов в тексте
    /// </summary>
    public class WordCountAnalyzer : IAnalyzer
    {
        /// <inheritdoc/>
        public string Name => "Подсчёт слов в тексте";

        /// <inheritdoc/>
        public List<string> Parameters => new List<string>();

        /// <inheritdoc/>
        public AnalysisResult Analyze(string text, List<string> parameters)
        {
            int count = TextParser.ParseIntoWords(text).Count;
            return new AnalysisResult($"Количество слов в тексте", count.ToString());
        }
    }
}
