using NUnit.Framework;
using System.Collections.Generic;
using TextAnalysisApp.Utils;

namespace TextAnalysisAppTest
{
    public class TextParserTests
    {
        [TestCaseSource(nameof(WordCases))]
        public void ParseIntoWordsTest(string text, string[] expected)
        {
            List<string> actual = TextParser.ParseIntoWords(text);
            CollectionAssert.AreEqual(new List<string>(expected), actual);
        }

        [TestCaseSource(nameof(SentenceCases))]
        public void ParseIntoSentencesTest(string text, string[] expected)
        {
            List<string> actual = TextParser.ParseIntoSentences(text);
            CollectionAssert.AreEqual(new List<string>(expected), actual);
        }

        [TestCaseSource(nameof(PunctuationCases))]
        public void ParseIntoPunctuationMarksTest(string text, string[] expected)
        {
            List<string> actual = TextParser.ParseIntoPunctuationMarks(text);
            CollectionAssert.AreEqual(new List<string>(expected), actual);
        }

        private static string[] Sentences =
        {
            "������ ������ �� ������ �����������.",
            "������� ListBox ������������ ����� ������� ������. �������� ��������� ����� �������� �������� �������� Items, ������� ��� ��� � ������ ����� ���� ��������� ������.",
            "",
            "� ����� ������������ ���� ��������� � ��� ����������� ������? � ���� ��� ��������� ����� ������ ���������� �������������� �������������! �� ����� ���������...",
            "������� �������������� �������������� �� ��������� ������: �����������, ������������� � �����������. ������������� ������� �������� �� ���������, ����������� - �� �������� ��������! �����-�� ������� ����� ���������� ���� � ������, � ��������� - ���!"
        };

        private static object[] WordCases =
        {
            new object[] { Sentences[0], new string[] { "������", "������", "��", "������", "�����������" } },
            new object[] { Sentences[1], new string[] { "�������", "ListBox", "������������", "�����", "�������", "������", "��������", "���������", "�����", "��������", "��������", "��������", "Items", "�������", "���", "���", "�", "������", "�����", "����", "���������", "������" } },
            new object[] { Sentences[2], new string[] { } },
            new object[] { Sentences[3], new string[] { "�", "�����", "������������", "����", "���������", "�", "���", "�����������", "������", "�", "����", "���", "���������", "�����", "������", "����������", "��������������", "�������������", "��", "�����", "���������" } },
            new object[] { Sentences[4], new string[] { "�������", "��������������", "��������������", "��", "���������", "������", "�����������", "�������������", "�", "�����������", "�������������", "�������", "��������", "��", "���������", "�����������", "��", "��������", "��������", "�����-��", "�������", "�����", "����������", "����", "�", "������", "�", "���������", "���" } }
        };

        private static object[] SentenceCases =
        {
            new object[] { Sentences[0], new string[] { "������ ������ �� ������ �����������." } },
            new object[] { Sentences[1], new string[] { "������� ListBox ������������ ����� ������� ������.", "�������� ��������� ����� �������� �������� �������� Items, ������� ��� ��� � ������ ����� ���� ��������� ������." } },
            new object[] { Sentences[2], new string[] { } },
            new object[] { Sentences[3], new string[] { "� ����� ������������ ���� ��������� � ��� ����������� ������?", "� ���� ��� ��������� ����� ������ ���������� �������������� �������������!", "�� ����� ���������..." } },
            new object[] { Sentences[4], new string[] { "������� �������������� �������������� �� ��������� ������: �����������, ������������� � �����������.", "������������� ������� �������� �� ���������, ����������� - �� �������� ��������!", "�����-�� ������� ����� ���������� ���� � ������, � ��������� - ���!" } },
        };

        private static object[] PunctuationCases =
        {
            new object[] { Sentences[0], new string[] { "." } },
            new object[] { Sentences[1], new string[] { ".", ",", "." } },
            new object[] { Sentences[2], new string[] { } },
            new object[] { Sentences[3], new string[] { "?", "!", "..." } },
            new object[] { Sentences[4], new string[] { ":", ",", ".", ",", "-", "!", ",", "-", "!" } }
        };
    }
}