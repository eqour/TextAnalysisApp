namespace TextAnalysisApp.Exceptions
{
    /// <summary>
    /// Исключение, которое создаётся при возникновении ошибки в анализаторе
    /// </summary>
    public class AnalyzerException : Exception
    {
        /// <inheritdoc/>
        public AnalyzerException()
        {
        }

        /// <inheritdoc/>
        public AnalyzerException(string message) : base(message)
        {
        }

        /// <inheritdoc/>
        public AnalyzerException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
