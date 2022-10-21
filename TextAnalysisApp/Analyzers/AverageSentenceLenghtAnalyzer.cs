using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalysisApp.Model;
using TextAnalysisApp.Utils;

namespace TextAnalysisApp.Analyzers
{
    public class AverageSentenceLenghtAnalyzer : IAnalyzer
    {
        public string Name => "Подсчёт средней длины предложений";

        public List<string> Parameters => new List<string>();

        public AnalysisResult Analyze(string text, List<string> parameters)
        {
            int amount = 0;
            var src = TextParser.ParseIntoSentences(text);
            foreach (var l in src)
            {
                amount += l.Length - 1;
            }
            amount /= src.Count;
            return new AnalysisResult($"Средняя длина предложений.", amount.ToString());
        }
    }
}