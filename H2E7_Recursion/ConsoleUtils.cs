using System;

namespace H2E7_Recursion
{
    public class ConsoleUtils
    {
        public static InputData InputData()
        {
            InputData data;

            Console.Write("Введите первое число: ");
            var value1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            var value2 = int.Parse(Console.ReadLine());

            if (!(value1 < value2))
            {
                Console.WriteLine("\nУсловие A<B не соблюдается. Введите данные еще раз");
                data = InputData();
                return data;
            }
            
            data = new InputData(value1, value2);
            return data;
        }

        public static void OutputData(Array array)
        {
            Console.WriteLine("\nРезульат:");
            Console.WriteLine($"Диапазон чисел [{array.Start};{array.End}] - {array.ArrayAsString}" +
                $"\nСумма чисел диапазона составляет {array.Sum}");
            Console.ReadKey();
        }
    }
}