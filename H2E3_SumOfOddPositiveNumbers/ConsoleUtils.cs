using System;
using System.Collections.Generic;

namespace H2E3_SumOfOddPositiveNumbers
{
    public class ConsoleUtils
    {
        public static List<int> InputData()
        {
            var result = new List<int>();
            int value;
            Console.WriteLine("Введите числа:");
            do
            {
                value = int.Parse(Console.ReadLine());
                result.Add(value);
            }
            while(value != 0);
            return result;
        }

        public static void OutputData(Numbers numbers)
        {
            Console.WriteLine("\nРезультат:");
            Console.WriteLine($"Сумма положительных четных чисел списка {numbers.ToString()} составляет {numbers.SumOfOddPositiveNumbers}");
            Console.ReadKey();
        }
    }
}