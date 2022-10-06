using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalysisApp.Model;
using TextAnalysisApp.Utils;

namespace TextAnalysisApp.Analyzers
{
    internal class SentenceCountAnalyzer : IAnalyzer
    {
        public string Name => "Подсчёт предложений в тексте.";

        public List<string> Parameters => new List<string>();

        public AnalysisResult Analyze(string text, List<string> parameters)
        {
            int count = TextParser.ParseIntoSentences(text).Count;
            return new AnalysisResult($"{count} предложений содержится в тексте.", count.ToString());
        }
    }
}