using System.Text.RegularExpressions;

namespace TextAnalysisApp.Utils
{
    /// <summary>
    /// Содержит методы для разбора текста
    /// </summary>
    public class TextParser
    {
        /// <summary>
        /// Разделители пробелов в тексте
        /// </summary>
        private static readonly char[] voidSeparators = new char[] { ' ', '\t', '\n', '\r' };

        /// <summary>
        /// Выполняет разбор текста на слова
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <returns>Список слов</returns>
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

        /// <summary>
        /// Выполняет разбор текста на предложения. В результирующие предложения входят завершающие их знаки препинания, если таковые присутствуют
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <returns>Список предложений</returns>
        public static List<string> ParseIntoSentences(string text)
        {
            List<string> ntext = new List<string>();
            if (text.Trim() != "")
            {
                ntext = Regex.Split(text, @"(?<=[\w\s](?:[\.\!\?]+[\x20]*[\x22\xBB]*))(?:\s+(?![\x22\xBB](?!\w)))").ToList();
            }
            return ntext;
        }
        
        /// <summary>
        /// Выполняет разбор текста на знаки препинания
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <returns>Список знаков препинания</returns>
        public static List<string> ParseIntoPunctuationMarks(string text)
        {
            return Parse(text, (t, i) => char.IsPunctuation(t, i) && !IsHyphen(t, i));
        }

        /// <summary>
        /// Выполняет разбор текста на подстроки
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <param name="splitSubstringsPredicate">Функция, определяющая, является ли символ строки частью слова</param>
        /// <returns></returns>
        private static List<string> Parse(string text, Func<string, int, bool> splitSubstringsPredicate)
        {
            List<string> ans = new List<string>();
            foreach (string fragment in SplitTextWithVoids(text))
                ans.AddRange(SelectSubstrings(fragment, splitSubstringsPredicate));
            return ans;
        }

        /// <summary>
        /// Разбивает текст по пробелам
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <returns>Список фрагментов текста, разделённых пробелами</returns>
        private static List<string> SplitTextWithVoids(string text)
        {
            return new List<string>(text.Split(voidSeparators));
        }

        /// <summary>
        /// Разбивает текст на подстроки с помощью функции
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <param name="predicate">Функция, определяющая, является ли символ строки частью слова</param>
        /// <returns>Список подстрок</returns>
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

        /// <summary>
        /// Определяет, является ли символ текста дефисом
        /// </summary>
        /// <param name="textWithoutSpaces">Текст без пробелов</param>
        /// <param name="indexOfDash">Индекс дефиса</param>
        /// <returns>Истина, если символ является дефисом, иначе ложь</returns>
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
