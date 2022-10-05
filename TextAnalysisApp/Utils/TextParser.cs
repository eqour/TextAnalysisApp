using System;
using System.Collections.Generic;

namespace TextAnalysisApp.Utils
{
    internal class TextParser
    {
        private static readonly char[] voidSeparators = new char[] { ' ', '\t', '\n', '\r' };
        private static readonly char[] sentenceEndings = new char[] { '.', '!', '?' };

        public static List<string> ParseIntoWords(string text)
        {
            return Parse(text, (t, i) => char.IsLetter(t, i) || IsHyphen(t, i));
        }

        public static List<string> ParseIntoSentences(string text)
        {
            return new List<string>(text.Split(sentenceEndings));
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
