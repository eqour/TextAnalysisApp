using System.Collections.Generic;
using TextAnalysisApp.Model;
using TextAnalysisApp.Utils;

namespace TextAnalysisApp.Analyzers
{
    public class PunctuationMarksCountAnalyzer : IAnalyzer
    {
        public string Name => "Количество знаков препинания";

        public List<string> Parameters => new List<string>();

        public AnalysisResult Analyze(string text, List<string> parameters)
        {
            int value = TextParser.ParseIntoPunctuationMarks(text).Count;
            return new AnalysisResult("Знаки препинания", value.ToString());
        }
    }
}
