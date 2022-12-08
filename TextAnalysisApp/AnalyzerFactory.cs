using TextAnalysisApp.Analyzers;
using TextAnalysisApp.Model;

namespace TextAnalysisApp
{
    /// <summary>
    /// Создаёт экземпляры классов анализаторов
    /// </summary>
    public class AnalyzerFactory
    {
        /// <summary>
        /// Создаёт список элементов, хранящих данные об анализаторах и их параметрах в виде элементов управления
        /// </summary>
        /// <returns>Список экземпляров класса <see cref="AnalyzerItem"/></returns>
        public static List<AnalyzerItem> CreateAnalyzerItems()
        {
            return CreateAnalyzers()
                .Select(analyzer => new AnalyzerItem(analyzer))
                .ToList();
        }

        /// <summary>
        /// Создаёт список анализаторов
        /// </summary>
        /// <returns>Список экземпляров класса, реализующих интерфейс <see cref="IAnalyzer"/></returns>
        public static List<IAnalyzer> CreateAnalyzers()
        {
            List<IAnalyzer> analyzers = new List<IAnalyzer>();
            analyzers.Add(new WordCountAnalyzer());
            analyzers.Add(new WordsByFirstLetterAnalyzer());
            analyzers.Add(new AverageSentenceLenghtAnalyzer());
            analyzers.Add(new SentenceCountAnalyzer());
            analyzers.Add(new PunctuationMarksCountAnalyzer());
            return analyzers;
        }
    }
}
