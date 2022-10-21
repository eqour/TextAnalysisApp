using NUnit.Framework;
using System;
using System.Collections.Generic;
using TextAnalysisApp.Utils;

namespace TextAnalysisAppTest
{
    public class TextParserTests
    {
        [TestCaseSource(nameof(WordCases))]
        public void ParseIntoWordsTest(string text, string[] expected)
        {
            RunWithIgnoreNotImplemented(() =>
            {
                List<string> actual = TextParser.ParseIntoWords(text);
                CollectionAssert.AreEqual(new List<string>(expected), actual);
            });
        }

        [TestCaseSource(nameof(SentenceCases))]
        public void ParseIntoSentencesTest(string text, string[] expected)
        {
            RunWithIgnoreNotImplemented(() =>
            {
                List<string> actual = TextParser.ParseIntoSentences(text);
                CollectionAssert.AreEqual(new List<string>(expected), actual);
            });
        }

        [TestCaseSource(nameof(PunctuationCases))]
        public void ParseIntoPunctuationMarksTest(string text, string[] expected)
        {
            RunWithIgnoreNotImplemented(() =>
            {
                List<string> actual = TextParser.ParseIntoPunctuationMarks(text);
                CollectionAssert.AreEqual(new List<string>(expected), actual);
            });
        }

        private void RunWithIgnoreNotImplemented(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (NotImplementedException)
            {
                Assert.Ignore();
            }
        }

        public static readonly object[] WordCases = ConfigureCases(i => new object[] { CasesSource.Texts[i], CasesSource.Words[i] });
        public static readonly object[] SentenceCases = ConfigureCases(i => new object[] { CasesSource.Texts[i], CasesSource.Sentences[i] });
        public static readonly object[] PunctuationCases = ConfigureCases(i => new object[] { CasesSource.Texts[i], CasesSource.PunctuationMarks[i] });

        private static object[] ConfigureCases(Func<int, object[]> casesSelector)
        {
            List<object[]> result = new List<object[]>();
            for (int i = 0; i < CasesSource.Texts.Length; i++)
            {
                result.Add(casesSelector.Invoke(i));
            }
            return result.ToArray();
        }
    }
}
