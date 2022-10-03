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
            
            String s = "На морских берегах я сижу, не в пространное море гляжу, но на небо глаза возвожу.";

            s = new string(s.Where(c => !char.IsPunctuation(c)).ToArray());

            Console.WriteLine(s);

            List<string> parts = new List<string>();

            parts.Add("На морских берегах я сижу, не в пространное море гляжу, но на небо глаза возвожу.");
            return(parts);


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
