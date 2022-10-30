using System;

namespace H3E2_SumOfOddPositiveNumbers
{
    public class ConsoleUtils
    {
        public static void InputData(Numbers nums)
        {
            var result = int.TryParse(Console.ReadLine(), out int data);
            if (result && data == 0) return;
            else
            {
                nums.Values.Add(data);
                InputData(nums);
            }
        }

        public static void OutputData(Numbers nums)
        {
            Console.WriteLine("\nРезультат:");
            Console.WriteLine($"В списке {nums} сумма нечентных положительных чисел - {nums.SumOfOddPositiveNumbers}");
            Console.ReadKey();
        }
    }
}