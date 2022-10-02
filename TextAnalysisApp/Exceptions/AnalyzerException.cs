using System;

namespace TextAnalysisApp.Exceptions
{
    internal class AnalyzerException : Exception
    {
        public AnalyzerException()
        {
        }

        public AnalyzerException(string message) : base(message)
        {
        }

        public AnalyzerException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
