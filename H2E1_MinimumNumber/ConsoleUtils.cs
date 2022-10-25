using System;

namespace H2E1_MinimumNumber
{
    public class ConsoleUtils
    {
        public static int InputData(string line)
        {
            Console.Write($"Введите {line} число: ");
            var value = int.Parse(Console.ReadLine());
            return value;
        }

        public static void OutputData(Number number)
        {
            Console.WriteLine("\nРезультат:");
            Console.WriteLine($"Среди чисел {number.FirstValue}, {number.SecondValue} и {number.ThirdValue} наименьшее {number.MinValue}");
            Console.ReadKey();
        }
    }
}