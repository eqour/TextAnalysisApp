using System.Collections.Generic;
using TextApp.Model;

namespace TextApp.Analyzers
{
    internal interface IAnalyzer
    {
        string Name { get; }
        List<string> Parameters { get; }
        AnalysisResult Analyse(string text, List<string> parameters);
    }
}
