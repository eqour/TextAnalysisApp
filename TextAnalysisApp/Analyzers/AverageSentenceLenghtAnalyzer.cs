using TextAnalysisApp.Model;
using TextAnalysisApp.Utils;

namespace TextAnalysisApp.Analyzers
{
    /// <summary>
    /// Анализатор, выполняющий подсчёт средней длины предложений в тексте
    /// </summary>
    public class AverageSentenceLenghtAnalyzer : IAnalyzer
    {
        /// <inheritdoc/>
        public string Name => "Подсчёт средней длины предложений";

        /// <inheritdoc/>
        public List<string> Parameters => new List<string>();

        /// <inheritdoc/>
        public AnalysisResult Analyze(string text, List<string> parameters)
        {
            double amount = 0;
            var src = TextParser.ParseIntoSentences(text);
            foreach (var l in src)
            {
                amount += l.Length;
            }
            double result = src.Count == 0 ? 0 : Math.Round(amount /= src.Count, 2);
            return new AnalysisResult($"Средняя длина предложений", result.ToString());
        }
    }
}