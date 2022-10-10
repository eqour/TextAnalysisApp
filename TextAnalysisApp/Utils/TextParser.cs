using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysisApp.Utils
{
    internal class TextParser
    {
        public static List<string> ParseIntoWords(string text)
        {
            List<string> parts = new List<string>();
            if (text.Length == 0)
                return parts;
            string r = text[0].ToString();
            for (int i = 1; i < text.Length - 1; i++)
            {
                char c;
                if (text[i] == '-' && char.IsLetter(text[i - 1]) && char.IsLetter(text[i + 1])) c = '_';
                else c = text[i];
                r += c;
            }
            r += text[text.Length - 1];
            string[] split = r.Split(' ', '!', ',', '?', '.', ':', '-', '\'');
            foreach (string s in split)
            {
                if (s != "")
                {
                    parts.Add(s.Replace('_', '-'));
                }
            }
            return (parts);
        }

        public static List<string> ParseIntoSentences(string text)
        {
            // todo: задача #3
            throw new NotImplementedException();
        }
        
        public static List<string> ParseIntoPunctuationMarks(string text)
        {
            // todo: задача #4
            throw new NotImplementedException();
        }
    }
}
