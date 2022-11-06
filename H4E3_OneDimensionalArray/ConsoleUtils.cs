using System;

namespace H4E3_OneDimensionalArray
{
    public class ConsoleUtils
    {
        public static void OutputData(OneDimensionalArray array)
        {
            Console.WriteLine($"Массив, с размером - {array.Count}, с начальным значением - {array.Start}, с шагом - {array.Step}:");
            Console.WriteLine($"{array.ToString()}");
            Console.WriteLine($"Сумма всех чисел массива - {array.Sum}");
            Console.WriteLine($"Результат работы метода {nameof(OneDimensionalArray.Inverse)} - {string.Join(", ", array.Inverse())}");
            Console.WriteLine($"Результат работы метода {nameof(OneDimensionalArray.Multi)} - {string.Join(", ", array.Multi(2))}");
            Console.ReadKey();
        }
    }
}