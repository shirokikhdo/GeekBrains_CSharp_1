using System;

namespace H4E5_TwoDimensionalArray
{
    public class ConsoleUtils
    {
        public static void OutputData(TwoDimensionalArray array)
        {
            Console.WriteLine("Двумерный массив:");
            Console.WriteLine(array.StringArray);
            Console.WriteLine($"Сумма всех элементов массива - {array.GetSum()}");
            Console.WriteLine($"Сумма всех элементов массива, которые больше 8 - {array.GetSum(8)}");
            Console.WriteLine($"Максимальное значение массива - {array.Max}");
            Console.WriteLine($"Позиция максимального значения массива - {string.Join(", ", array.Position)}");
            Console.WriteLine($"Минимальное значение массива - {array.Min}");
            Console.ReadKey();
        }

        public static void Pause(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}