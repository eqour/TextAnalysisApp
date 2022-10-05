using System.Collections.Generic;
using System.Linq;
using TextAnalysisApp.Model;
using TextAnalysisApp.Utils;

namespace TextAnalysisApp.Analyzers
{
    internal class AverageSentenceLengthAnalyzer : IAnalyzer
    {
        public string Name => "Средняя длина предложения";

        public List<string> Parameters => new List<string>();

        public AnalysisResult Analyze(string text, List<string> parameters)
        {
            double value = TextParser.ParseIntoSentences(text)
                .Average(sentence => sentence.Length);
            return new AnalysisResult("Средняя длина предложения", value.ToString());
        }
    }
}
