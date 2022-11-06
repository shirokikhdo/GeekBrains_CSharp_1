using System;

namespace H4E1_ArrayPairs
{
    public class ConsoleUtils
    {
        public static void OutputData(Array array)
        {
            var pairs = array.GetValidPairs();
            Console.WriteLine("В массиве:");
            Console.WriteLine($"{array.ToString()}");
            Console.WriteLine("Пары, в которых одно число делится на 3:");
            Console.WriteLine($"{string.Join("\n", pairs)}");
            Console.WriteLine($"Ответ: {pairs.Count} пар");
            Console.ReadKey();
        }
    }
}