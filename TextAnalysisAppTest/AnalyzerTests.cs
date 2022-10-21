using NUnit.Framework;
using System.Linq;
using TextAnalysisApp;
using TextAnalysisApp.Analyzers;

namespace TextAnalysisAppTest
{
    internal class AnalyzerTests
    {
        [TestCaseSource(nameof(Analyzers))]
        public void DefaultAnalyzerTest(IAnalyzer analyzer)
        {
            Assert.AreNotEqual(analyzer.Name, null);
            Assert.AreNotEqual(analyzer.Name.Trim().Length, 0);
            Assert.AreNotEqual(analyzer.Parameters, null);
        }

        private static object[] Analyzers = AnalyzerFactory.CreateAnalyzers().Select(a => new object[] { a }).ToArray();
    }
}
