using System;

namespace H1E4_Swap
{
    public class ConsoleUtils
    {
        public static int InputData(string number)
        {
            Console.Write($"Введи {number} значение: ");
            var value = int.Parse(Console.ReadLine());
            return value;
        }

        public static void OutputData(Swapper swapper)
        {
            Console.WriteLine("\nРезультат:");
            Console.WriteLine($"С использованием третьей переменной - {swapper.SwapWithTemp()};");
            Console.WriteLine($"Без использование третьей переменной обратно - {swapper.SwapWithoutTemp()}.");
            Console.ReadKey();
        }
    }
}