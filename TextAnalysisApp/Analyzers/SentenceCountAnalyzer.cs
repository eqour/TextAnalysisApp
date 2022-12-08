using TextAnalysisApp.Model;
using TextAnalysisApp.Utils;

namespace TextAnalysisApp.Analyzers
{
    /// <summary>
    /// Анализатор, выполняющий подсчёт предложений в тексте
    /// </summary>
    public class SentenceCountAnalyzer : IAnalyzer
    {
        /// <inheritdoc/>
        public string Name => "Подсчёт предложений в тексте";

        /// <inheritdoc/>
        public List<string> Parameters => new List<string>();

        /// <inheritdoc/>
        public AnalysisResult Analyze(string text, List<string> parameters)
        {
            int count = TextParser.ParseIntoSentences(text).Count;
            return new AnalysisResult($"Количество предложений в тексте", count.ToString());
        }
    }
}