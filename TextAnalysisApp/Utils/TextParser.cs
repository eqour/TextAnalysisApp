using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextAnalysisApp.Utils
{
    public class TextParser
    {
        private static readonly char[] voidSeparators = new char[] { ' ', '\t', '\n', '\r' };
        public static List<string> ParseIntoWords(string text)
        {
            // todo: задача #2
            throw new NotImplementedException();
        }

        public static List<string> ParseIntoSentences(string text)
        {
            List<string> ntext = new List<string>();
            if (text.Trim() != "")
            {
                ntext = Regex.Split(text, @"(?<=[\w\s](?:[\.\!\?]+[\x20]*[\x22\xBB]*))(?:\s+(?![\x22\xBB](?!\w)))").ToList();
            }
            return ntext;
        }
        
        public static List<string> ParseIntoPunctuationMarks(string text)
        {
            return Parse(text, (t, i) => char.IsPunctuation(t, i) && !IsHyphen(t, i));
        }
        private static List<string> Parse(string text, Func<string, int, bool> splitSubstringsPredicate)
        {
            List<string> ans = new List<string>();
            foreach (string fragment in SplitTextWithVoids(text))
                ans.AddRange(SelectSubstrings(fragment, splitSubstringsPredicate));
            return ans;
        }

        private static List<string> SplitTextWithVoids(string text)
        {
            return new List<string>(text.Split(voidSeparators));
        }

        private static List<string> SelectSubstrings(string text, Func<string, int, bool> predicate)
        {
            int start = -1, end = 0;
            List<string> ans = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                if (start == -1)
                {
                    if (predicate.Invoke(text, i))
                    {
                        start = end = i;
                    }
                }
                if (start != -1)
                {
                    if (predicate.Invoke(text, i))
                    {
                        end = i;
                        if (i == text.Length - 1)
                        {
                            ans.Add(text.Substring(start));
                        }
                    }
                    else
                    {
                        ans.Add(text.Substring(start, end - start + 1));
                        start = -1;
                    }
                }
            }
            return ans;
        }

        private static bool IsHyphen(string textWithoutSpaces, int indexOfDash)
        {
            string t = textWithoutSpaces;
            int i = indexOfDash;
            return i > 0
                && i < t.Length - 1
                && t[i] == '-'
                && char.IsLetterOrDigit(t, i - 1)
                && char.IsLetterOrDigit(t, i + 1);
        }
    }
}
