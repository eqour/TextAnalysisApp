using System.Collections.Generic;
using TextAnalysisApp.Model;

namespace TextAnalysisApp.Analyzers
{
    internal interface IAnalyzer
    {
        string Name { get; }
        List<string> Parameters { get; }
        AnalysisResult Analyze(string text, List<string> parameters);
    }
}
