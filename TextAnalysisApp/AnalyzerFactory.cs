using System.Collections.Generic;
using System.Linq;
using TextAnalysisApp.Analyzers;

namespace TextAnalysisApp.Model
{
    internal class AnalyzerFactory
    {
        public static List<AnalyzerItem> CreateAnalyzerItems()
        {
            return CreateAnalyzers()
                .Select(analyzer => new AnalyzerItem(analyzer))
                .ToList();
        }

        private static List<IAnalyzer> CreateAnalyzers()
        {
            List<IAnalyzer> analyzers = new List<IAnalyzer>();
            analyzers.Add(new WordsByFirstLetterAnalyzer());
            return analyzers;
        }
    }
}
