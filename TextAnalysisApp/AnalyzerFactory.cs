using System.Collections.Generic;
using System.Linq;
using TextApp.Analyzers;

namespace TextApp.Model
{
    internal class AnalyzerFactory
    {
        public static List<AnalyzerItem> createAnalyzerItems()
        {
            return createAnalyzers()
                .Select(analyzer => new AnalyzerItem(analyzer))
                .ToList();
        }

        private static List<IAnalyzer> createAnalyzers()
        {
            List<IAnalyzer> analyzers = new List<IAnalyzer>();
            return analyzers;
        }
    }
}
