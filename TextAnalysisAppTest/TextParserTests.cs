using NUnit.Framework;
using System;
using System.Collections.Generic;
using TextAnalysisApp.Utils;

namespace TextAnalysisAppTest
{
    public class TextParserTests
    {
        [TestCaseSource(nameof(WordCases))]
        public void ParseIntoWordsTest(string text, string[] expected)
        {
            RunWithIgnoreNotImplemented(() =>
            {
                List<string> actual = TextParser.ParseIntoWords(text);
                CollectionAssert.AreEqual(new List<string>(expected), actual);
            });
        }

        [TestCaseSource(nameof(SentenceCases))]
        public void ParseIntoSentencesTest(string text, string[] expected)
        {
            RunWithIgnoreNotImplemented(() =>
            {
                List<string> actual = TextParser.ParseIntoSentences(text);
                CollectionAssert.AreEqual(new List<string>(expected), actual);
            });
        }

        [TestCaseSource(nameof(PunctuationCases))]
        public void ParseIntoPunctuationMarksTest(string text, string[] expected)
        {
            RunWithIgnoreNotImplemented(() =>
            {
                List<string> actual = TextParser.ParseIntoPunctuationMarks(text);
                CollectionAssert.AreEqual(new List<string>(expected), actual);
            });
        }

        private void RunWithIgnoreNotImplemented(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (NotImplementedException)
            {
                Assert.Ignore();
            }
        }

        private static string[] Sentences =
        {
            "Пример текста из одного предложения.",
            "Элемент ListBox представляет собой простой список. Ключевым свойством этого элемента является свойство Items, которое как раз и хранит набор всех элементов списка.",
            "",
            "А вдруг разработчики базы допустили в ней критическую ошибку? А ведь это важнейшая часть работы подсистемы аутентификации пользователей! Всё очень непонятно...",
            "Шаблоны проектирования подразделяются на следующие группы: порождающие, поведенческие и структурные. Поведенческие шаблоны отвечают за поведение, порождающие - за создание объектов! Какие-то шаблоны можно объединять друг с другом, а некоторые - нет!",
            "If someone force pushes to a branch, the force push may overwrite commits that other collaborators based their work on. People may have merge conflicts or corrupted pull requests."
        };

        private static object[] WordCases =
        {
            new object[] { Sentences[0], new string[] { "Пример", "текста", "из", "одного", "предложения" } },
            new object[] { Sentences[1], new string[] { "Элемент", "ListBox", "представляет", "собой", "простой", "список", "Ключевым", "свойством", "этого", "элемента", "является", "свойство", "Items", "которое", "как", "раз", "и", "хранит", "набор", "всех", "элементов", "списка" } },
            new object[] { Sentences[2], new string[] { } },
            new object[] { Sentences[3], new string[] { "А", "вдруг", "разработчики", "базы", "допустили", "в", "ней", "критическую", "ошибку", "А", "ведь", "это", "важнейшая", "часть", "работы", "подсистемы", "аутентификации", "пользователей", "Всё", "очень", "непонятно" } },
            new object[] { Sentences[4], new string[] { "Шаблоны", "проектирования", "подразделяются", "на", "следующие", "группы", "порождающие", "поведенческие", "и", "структурные", "Поведенческие", "шаблоны", "отвечают", "за", "поведение", "порождающие", "за", "создание", "объектов", "Какие-то", "шаблоны", "можно", "объединять", "друг", "с", "другом", "а", "некоторые", "нет" } },
            new object[] { Sentences[5], new string[] { "If", "someone", "force", "pushes", "to", "a", "branch", "the", "force", "push", "may", "overwrite", "commits", "that", "other", "collaborators", "based", "their", "work", "on", "People", "may", "have", "merge", "conflicts", "or", "corrupted", "pull", "requests" } }
        };

        private static object[] SentenceCases =
        {
            new object[] { Sentences[0], new string[] { "Пример текста из одного предложения." } },
            new object[] { Sentences[1], new string[] { "Элемент ListBox представляет собой простой список.", "Ключевым свойством этого элемента является свойство Items, которое как раз и хранит набор всех элементов списка." } },
            new object[] { Sentences[2], new string[] { } },
            new object[] { Sentences[3], new string[] { "А вдруг разработчики базы допустили в ней критическую ошибку?", "А ведь это важнейшая часть работы подсистемы аутентификации пользователей!", "Всё очень непонятно..." } },
            new object[] { Sentences[4], new string[] { "Шаблоны проектирования подразделяются на следующие группы: порождающие, поведенческие и структурные.", "Поведенческие шаблоны отвечают за поведение, порождающие - за создание объектов!", "Какие-то шаблоны можно объединять друг с другом, а некоторые - нет!" } },
            new object[] { Sentences[5], new string[] { "If someone force pushes to a branch, the force push may overwrite commits that other collaborators based their work on.", "People may have merge conflicts or corrupted pull requests." } }
        };

        private static object[] PunctuationCases =
        {
            new object[] { Sentences[0], new string[] { "." } },
            new object[] { Sentences[1], new string[] { ".", ",", "." } },
            new object[] { Sentences[2], new string[] { } },
            new object[] { Sentences[3], new string[] { "?", "!", "..." } },
            new object[] { Sentences[4], new string[] { ":", ",", ".", ",", "-", "!", ",", "-", "!" } },
            new object[] { Sentences[5], new string[] { ",", ".", "." } }
        };
    }
}
