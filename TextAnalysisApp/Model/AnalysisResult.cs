namespace TextAnalysisApp.Model
{
    /// <summary>
    /// Представляет собой результат анализа текста
    /// </summary>
    public class AnalysisResult
    {
        /// <summary>
        /// Название результата анализа
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Значение результата анализа
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AnalysisResult"/>
        /// </summary>
        /// <param name="name">Название результата анализа</param>
        /// <param name="value">Значение результата анализа</param>
        public AnalysisResult(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}
