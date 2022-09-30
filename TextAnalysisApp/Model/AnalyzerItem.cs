using System.Collections.Generic;
using System.Linq;
using TextApp.Analyzers;
using TextApp.View.Items;

namespace TextApp.Model
{
    internal class AnalyzerItem
    {
        public string Name => analyzer.Name;
        public List<AnalyzerParameterItem> AnalyzerParameterItems { get; }

        private readonly IAnalyzer analyzer;

        public AnalyzerItem(IAnalyzer analyzer)
        {
            this.analyzer = analyzer;
            AnalyzerParameterItems = analyzer.Parameters
                .Select(parameter => new AnalyzerParameterItem(parameter))
                .ToList();
        }

        public AnalysisResult ExecuteAnalysis(string text)
        {
            List<string> parametersValues = AnalyzerParameterItems
                .Select(item => item.Value)
                .ToList();
            return analyzer.Analyse(text, parametersValues);
        }
    }
}
