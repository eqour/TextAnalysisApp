using NUnit.Framework;
using System.Collections.Generic;
using TextAnalysisApp.Analyzers;
using TextAnalysisApp.Model;

namespace TextAnalysisAppTest.AnalyzersTests
{
    internal class PunctuationMarksCountAnalyzerTests
    {
        [TestCaseSource(nameof(TestCases))]
        public void AnalyzeTest(string text, List<string> parameters, string analysisResultValue)
        {
            IAnalyzer analyzer = new PunctuationMarksCountAnalyzer();
            AnalysisResult result = analyzer.Analyze(text, parameters);
            Assert.NotNull(result);
            Assert.IsNotEmpty(result.Name);
            Assert.AreEqual(analysisResultValue, result.Value);
        }

        private static List<string> AnalysisResultValues = new List<string>
        {
            "1",
            "3",
            "0",
            "3",
            "9",
            "3"
        };

        private static object[] TestCases = CasesSource.ConfigureCases(i => new object[] { CasesSource.Texts[i], new List<string>(), AnalysisResultValues[i] });
    }
}
