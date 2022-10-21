using System.Collections.Generic;

namespace TextAnalysisAppTest
{
    public static class CasesSource
    {
        public static readonly string[] Texts =
        {
            "Пример текста из одного предложения.",
            "Элемент ListBox представляет собой простой список. Ключевым свойством этого элемента является свойство Items, которое как раз и хранит набор всех элементов списка.",
            "",
            "А вдруг разработчики базы допустили в ней критическую ошибку? А ведь это важнейшая часть работы подсистемы аутентификации пользователей! Всё очень непонятно...",
            "Шаблоны проектирования подразделяются на следующие группы: порождающие, поведенческие и структурные. Поведенческие шаблоны отвечают за поведение, порождающие - за создание объектов! Какие-то шаблоны можно объединять друг с другом, а некоторые - нет!",
            "If someone force pushes to a branch, the force push may overwrite commits that other collaborators based their work on. People may have merge conflicts or corrupted pull requests."
        };

        public static readonly List<string[]> Words = new List<string[]>
        {
            new string[] { "Пример", "текста", "из", "одного", "предложения" },
            new string[] { "Элемент", "ListBox", "представляет", "собой", "простой", "список", "Ключевым", "свойством", "этого", "элемента", "является", "свойство", "Items", "которое", "как", "раз", "и", "хранит", "набор", "всех", "элементов", "списка" },
            new string[] { },
            new string[] { "А", "вдруг", "разработчики", "базы", "допустили", "в", "ней", "критическую", "ошибку", "А", "ведь", "это", "важнейшая", "часть", "работы", "подсистемы", "аутентификации", "пользователей", "Всё", "очень", "непонятно" },
            new string[] { "Шаблоны", "проектирования", "подразделяются", "на", "следующие", "группы", "порождающие", "поведенческие", "и", "структурные", "Поведенческие", "шаблоны", "отвечают", "за", "поведение", "порождающие", "за", "создание", "объектов", "Какие-то", "шаблоны", "можно", "объединять", "друг", "с", "другом", "а", "некоторые", "нет" },
            new string[] { "If", "someone", "force", "pushes", "to", "a", "branch", "the", "force", "push", "may", "overwrite", "commits", "that", "other", "collaborators", "based", "their", "work", "on", "People", "may", "have", "merge", "conflicts", "or", "corrupted", "pull", "requests" }
        };

        public static readonly List<string[]> Sentences = new List<string[]>
        {
            new string[] { "Пример текста из одного предложения." },
            new string[] { "Элемент ListBox представляет собой простой список.", "Ключевым свойством этого элемента является свойство Items, которое как раз и хранит набор всех элементов списка." },
            new string[] { },
            new string[] { "А вдруг разработчики базы допустили в ней критическую ошибку?", "А ведь это важнейшая часть работы подсистемы аутентификации пользователей!", "Всё очень непонятно..." },
            new string[] { "Шаблоны проектирования подразделяются на следующие группы: порождающие, поведенческие и структурные.", "Поведенческие шаблоны отвечают за поведение, порождающие - за создание объектов!", "Какие-то шаблоны можно объединять друг с другом, а некоторые - нет!" },
            new string[] { "If someone force pushes to a branch, the force push may overwrite commits that other collaborators based their work on.", "People may have merge conflicts or corrupted pull requests." }
        };

        public static readonly List<string[]> PunctuationMarks = new List<string[]>
        {
            new string[] { "." },
            new string[] { ".", ",", "." },
            new string[] { },
            new string[] { "?", "!", "..." },
            new string[] { ":", ",", ".", ",", "-", "!", ",", "-", "!" },
            new string[] { ",", ".", "." }
        };
    }
}
