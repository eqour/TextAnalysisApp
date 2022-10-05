using System.Collections.Generic;
using TextAnalysisApp.Model;
using TextAnalysisApp.Utils;

namespace TextAnalysisApp.Analyzers
{
    internal class SentenceCountAnalyzer : IAnalyzer
    {
        public string Name => "Количество предложений";

        public List<string> Parameters => new List<string>();

        public AnalysisResult Analyze(string text, List<string> parameters)
        {
            int value = TextParser.ParseIntoSentences(text).Count;
            return new AnalysisResult("Предложения", value.ToString());
        }
    }
}
