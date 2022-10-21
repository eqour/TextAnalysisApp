using NUnit.Framework;
using System.Collections.Generic;
using TextAnalysisApp.Analyzers;
using TextAnalysisApp.Model;

namespace TextAnalysisAppTest.AnalyzersTests
{
    internal class WordCountAnalyzerTests
    {
        [TestCaseSource(nameof(TestCases))]
        public void AnalyzeTest(string text, List<string> parameters, string analysisResultValue)
        {
            IAnalyzer analyzer = new WordCountAnalyzer();
            AnalysisResult result = analyzer.Analyze(text, parameters);
            Assert.NotNull(result);
            Assert.IsNotEmpty(result.Name);
            Assert.AreEqual(analysisResultValue, result.Value);
        }

        private static List<string> AnalysisResultValues = new List<string>
        {
            "5",
            "22",
            "0",
            "21",
            "29",
            "29"
        };

        private static object[] TestCases = CasesSource.ConfigureCases(i => new object[] { CasesSource.Texts[i], new List<string>(), AnalysisResultValues[i] });
    }
}
