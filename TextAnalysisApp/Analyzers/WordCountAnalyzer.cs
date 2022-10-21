using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalysisApp.Model;
using TextAnalysisApp.Utils;

namespace TextAnalysisApp.Analyzers
{
    public class WordCountAnalyzer : IAnalyzer
    {
        public string Name => "Подсчёт слов в тексте";

        public List<string> Parameters => new List<string>();

        public AnalysisResult Analyze(string text, List<string> parameters)
        {
            int count = TextParser.ParseIntoWords(text).Count;
            return new AnalysisResult($"Количество слов в тексте", count.ToString());
        }
    }
}
