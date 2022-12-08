using TextAnalysisApp.Model;
using TextAnalysisApp.Utils;

namespace TextAnalysisApp.Analyzers
{
    /// <summary>
    /// Анализатор, определяющий количество знаков препинания в тексте
    /// </summary>
    public class PunctuationMarksCountAnalyzer : IAnalyzer
    {
        /// <inheritdoc/>
        public string Name => "Количество знаков препинания";

        /// <inheritdoc/>
        public List<string> Parameters => new List<string>();

        /// <inheritdoc/>
        public AnalysisResult Analyze(string text, List<string> parameters)
        {
            int value = TextParser.ParseIntoPunctuationMarks(text).Count;
            return new AnalysisResult("Знаки препинания", value.ToString());
        }
    }
}
