using System;

namespace H2E2_DigitsCountOfNumber
{
    public class ConsoleUtils
    {
        public static int InputData()
        {
            Console.Write("Введите число: ");
            var value = int.Parse(Console.ReadLine());
            return value;
        }

        public static void OutputData(Number number)
        {
            Console.WriteLine("\nРезультат:");
            Console.WriteLine($"Количество цифр в числе {number.Value} составляет {number.DigitsCount}");
            Console.ReadKey();
        }
    }
}