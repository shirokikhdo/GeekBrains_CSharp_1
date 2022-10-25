using System;

namespace H2E6_GoodNumbersCount
{
    public class ConsoleUtils
    {
        public static void OutputData(Array array)
        {
            Console.WriteLine("Результат:");
            Console.WriteLine($"Количество \"хороших\" чисел в диапазоне [1;1_000_000_000] составляет {array.GoodNumbersCount}" +
                $"\nНа операцию затрачено {array.Time}");
            Console.ReadKey();
        }
    }
}