﻿namespace TextAnalysisApp.Model
{
    public class AnalysisResult
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public AnalysisResult(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}
