using TextAnalysisApp.Analyzers;
using TextAnalysisApp.View.Items;

namespace TextAnalysisApp.Model
{
    /// <summary>
    /// Содержит данные об анализаторе и его параметрах в виде элементов управления
    /// </summary>
    public class AnalyzerItem
    {
        /// <summary>
        /// Возвращает название анализатора
        /// </summary>
        public string Name => analyzer.Name;

        /// <summary>
        /// Возвращает список элементов управления для ввода параметров анализатора
        /// </summary>
        public List<AnalyzerParameterItem> AnalyzerParameterItems { get; }

        /// <summary>
        /// Анализатор
        /// </summary>
        private readonly IAnalyzer analyzer;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AnalyzerItem"/>
        /// </summary>
        /// <param name="analyzer">Анализатор текста</param>
        public AnalyzerItem(IAnalyzer analyzer)
        {
            this.analyzer = analyzer;
            AnalyzerParameterItems = analyzer.Parameters
                .Select(parameter => new AnalyzerParameterItem(parameter))
                .ToList();
        }

        /// <summary>
        /// Выполняет анализ текста
        /// </summary>
        /// <param name="text">Текст, для которого выполняется анализ</param>
        /// <returns>Результат анализа</returns>
        public AnalysisResult ExecuteAnalysis(string text)
        {
            List<string> parametersValues = AnalyzerParameterItems
                .Select(item => item.Value)
                .ToList();
            return analyzer.Analyze(text, parametersValues);
        }
    }
}
