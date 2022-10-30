/*
а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
*/

namespace H3E2_SumOfOddPositiveNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var nums = new Numbers();
            ConsoleUtils.InputData(nums);
            ConsoleUtils.OutputData(nums);
        }
    }
}