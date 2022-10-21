using NUnit.Framework;
using System.Collections.Generic;
using TextAnalysisApp.Analyzers;
using TextAnalysisApp.Exceptions;
using TextAnalysisApp.Model;

namespace TextAnalysisAppTest.AnalyzersTests
{
    internal class WordsByFirstLetterAnalyzerTests
    {
        [TestCaseSource(nameof(WrongParameters))]
        public void AnalyzeWithWrongParameter(string wrongParameter)
        {
            try
            {
                new WordsByFirstLetterAnalyzer().Analyze("", new List<string>() { wrongParameter });
                Assert.Fail();
            }
            catch (AnalyzerException)
            {
                Assert.Pass();
            }
        }

        private static object[] WrongParameters =
        {
            new object[] { "" },
            new object[] { "aBc" },
            new object[] { "ab" },
            new object[] { "Аб" },
            new object[] { "нН" },
            new object[] { " " },
            new object[] { "\t" },
            new object[] { "-" },
            new object[] { "?" },
            new object[] { "*" }
        };

        [TestCaseSource(nameof(TestCases))]
        public void AnalyzeTest(string text, List<string> parameters, string analysisResultValue)
        {
            IAnalyzer analyzer = new WordsByFirstLetterAnalyzer();
            AnalysisResult result = analyzer.Analyze(text, parameters);
            Assert.NotNull(result);
            Assert.IsNotEmpty(result.Name);
            Assert.AreEqual(analysisResultValue, result.Value);
        }

        private static Dictionary<string, List<string>> AnalysisResultValues = new Dictionary<string, List<string>>
        {
            { "е", new List<string> { "0", "0", "0", "0", "0", "0" } },
            { "п", new List<string> { "1", "2", "0", "2", "6", "0" } },
            { "А", new List<string> { "0", "0", "0", "2", "0", "0" } },
            { "m", new List<string> { "0", "0", "0", "0", "0", "3" } }
        };

        private static object[] ConfigureTestParameters()
        {
            List<object[]> result = new List<object[]>();
            foreach (var resultValuePairs in AnalysisResultValues)
            {
                for (int i = 0; i < CasesSource.Texts.Length; i++)
                {
                    result.Add(new object[] { CasesSource.Texts[i],
                        new List<string> { resultValuePairs.Key }, resultValuePairs.Value[i] });
                }
            }
            return result.ToArray();
        }

        private static object[] TestCases = ConfigureTestParameters();
    }
}
