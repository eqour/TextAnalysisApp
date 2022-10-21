using System.Collections.Generic;
using System.Linq;
using TextAnalysisApp.Analyzers;
using TextAnalysisApp.Model;

namespace TextAnalysisApp
{
    public class AnalyzerFactory
    {
        public static List<AnalyzerItem> CreateAnalyzerItems()
        {
            return CreateAnalyzers()
                .Select(analyzer => new AnalyzerItem(analyzer))
                .ToList();
        }

        public static List<IAnalyzer> CreateAnalyzers()
        {
            List<IAnalyzer> analyzers = new List<IAnalyzer>();
            analyzers.Add(new WordCountAnalyzer());
            analyzers.Add(new WordsByFirstLetterAnalyzer());
            analyzers.Add(new AverageSentenceLenghtAnalyzer());
            analyzers.Add(new SentenceCountAnalyzer());
            analyzers.Add(new PunctuationMarksCountAnalyzer());
            return analyzers;
        }
    }
}
