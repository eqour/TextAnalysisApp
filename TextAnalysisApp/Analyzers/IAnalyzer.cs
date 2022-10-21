using System.Collections.Generic;
using TextAnalysisApp.Model;

namespace TextAnalysisApp.Analyzers
{
    public interface IAnalyzer
    {
        string Name { get; }
        List<string> Parameters { get; }
        AnalysisResult Analyze(string text, List<string> parameters);
    }
}
