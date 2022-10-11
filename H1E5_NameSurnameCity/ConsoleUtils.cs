using System;

namespace H1E5_NameSurnameCity
{
    public class ConsoleUtils
    {
        public static void OutputData(Person person)
        {
            var line = person.ToString();
            var x = (Console.WindowWidth - line.Length) / 2;
            var y = Console.WindowHeight / 2;
            _outputData(line, x, y);
        }

        private static void _outputData(string line, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(line);
            Console.ReadKey();
        }
    }
}