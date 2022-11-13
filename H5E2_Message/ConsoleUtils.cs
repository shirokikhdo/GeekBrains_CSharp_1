using System;
using System.Linq;
using System.Text;

namespace H5E2_Message
{
    public class ConsoleUtils
    {
        public static string InputData()
        {
            Console.WriteLine("Введите текст:");
            var msg = Console.ReadLine();
            return msg;
        }

        public static void OutputData(string msg)
        {
            Console.WriteLine("\nРезультат:");
            Console.WriteLine($"Слова, количество символов которых больше 5-ти - {Message.GetWordsWhereLetterCountMoreThan(msg)}");
            Console.WriteLine($"Слова, последний символ которых не равен \"я\" - {Message.GetWordsWhereLastLetterIsNot(msg, 'я')}");
            Console.WriteLine($"Самое длинное слово - {Message.GetLongestWord(msg)}");
            var sb = Message.GetLongestWords(msg);
            var list = sb.Replace("\r\n", " ").ToString().Split(' ').Where(x=>x!=string.Empty);
            Console.WriteLine($"Самые длинные слова - {string.Join(", ", list)}");
            var array = new string[] {"выражение", "шаблон"};
            var dictSb = new StringBuilder();
            var dict = Message.TextFrequencyAnalysis(array, msg);
            foreach(var item in dict)
            {
                var line = $"{item.Key} - {item.Value}";
                dictSb.AppendLine(line);
            }
            Console.WriteLine($"Частотный анализ текста:");
            Console.WriteLine($"{dictSb}");
            Console.ReadKey();
        }
    }
}