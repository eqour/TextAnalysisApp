using System.Collections.Generic;
using TextAnalysisApp.Model;
using TextAnalysisApp.Utils;

namespace TextAnalysisApp.Analyzers
{
    internal class WordCountAnalyzer : IAnalyzer
    {
        public string Name => "Количество слов";

        public List<string> Parameters => new List<string>();

        public AnalysisResult Analyze(string text, List<string> parameters)
        {
            int value = TextParser.ParseIntoWords(text).Count;
            return new AnalysisResult("Слова", value.ToString());
        }
    }
}
