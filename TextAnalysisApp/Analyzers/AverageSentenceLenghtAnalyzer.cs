using System;
using System.Collections.Generic;
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