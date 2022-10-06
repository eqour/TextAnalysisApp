using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextAnalysisApp.Utils
{
    internal class TextParser
    {
        public static List<string> ParseIntoWords(string text)
        {
            // todo: задача #2
            throw new NotImplementedException();
        }

        public static List<string> ParseIntoSentences(string text)
        {
            List<string> ntext = Regex.Split(text, @"(?<=[\w\s](?:[\.\!\?]+[\x20]*[\x22\xBB]*))(?:\s+(?![\x22\xBB](?!\w)))").ToList();
            return ntext;
        }
        
        public static List<string> ParseIntoPunctuationMarks(string text)
        {
            // todo: задача #4
            throw new NotImplementedException();
        }
    }
}
