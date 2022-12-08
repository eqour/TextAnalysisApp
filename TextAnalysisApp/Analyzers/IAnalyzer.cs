using TextAnalysisApp.Model;

namespace TextAnalysisApp.Analyzers
{
    /// <summary>
    /// Определяет свойства и методы для анализаторов
    /// </summary>
    public interface IAnalyzer
    {
        /// <summary>
        /// Возвращает название анализатора
        /// </summary>
        string Name { get; }
        
        /// <summary>
        /// Возвращает список названий параметров инициализатора
        /// </summary>
        List<string> Parameters { get; }
        
        /// <summary>
        /// Выполняет анализ текста
        /// </summary>
        /// <param name="text">Текст для анализа</param>
        /// <param name="parameters">Список параметров</param>
        /// <returns>Результат анализа</returns>
        AnalysisResult Analyze(string text, List<string> parameters);
    }
}
