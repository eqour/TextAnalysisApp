using System.Collections.Generic;
using System.Linq;
using TextAnalysisApp.Exceptions;
using TextAnalysisApp.Model;
using TextAnalysisApp.Utils;

namespace TextAnalysisApp.Analyzers
{
    internal class WordByFirstLetterCountAnalyzer : IAnalyzer
    {
        public string Name => "Количество слов, начинающихся с определённой буквы";

        public List<string> Parameters => new List<string>() { "Первая буква слова" };

        public AnalysisResult Analyze(string text, List<string> parameters)
        {
            string letter = parameters[0];
            if (letter.Length != 1)
                throw new AnalyzerException("Значение парметра \"Первая буква слова\" должно состоять из одного символа.");
            int amount = TextParser.ParseIntoWords(text)
                .Where(word => word.StartsWith(letter))
                .Count();
            return new AnalysisResult($"Слова с буквы {letter}", amount.ToString());
        }
    }
}