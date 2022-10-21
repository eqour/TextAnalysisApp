using System;

namespace TextAnalysisApp.Exceptions
{
    public class AnalyzerException : Exception
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
