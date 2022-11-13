using System;

namespace H5E3_StringComparison
{
    public class ConsoleUtils
    {
        public static Comparer InputData()
        {
            Console.Write("Введите первое слово: ");
            var value1 = Console.ReadLine();
            Console.Write("Введите второе слово: ");
            var value2 = Console.ReadLine();
            var data = new Comparer(value1, value2);
            return data;
        }

        public static void OutputData(Comparer comparer)
        {
            Console.WriteLine("\nРезультат:");
            Console.WriteLine($"Результат перестановки - {comparer.IsTansposition()}");
            Console.ReadKey();
        }
    }
}