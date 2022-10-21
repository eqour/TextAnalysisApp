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
            Assert.NotNull(analyzer.Name);
            Assert.IsNotEmpty(analyzer.Name);
            Assert.NotNull(analyzer.Parameters);
        }

        private static object[] Analyzers = AnalyzerFactory.CreateAnalyzers().Select(a => new object[] { a }).ToArray();
    }
}
