/*
С клавиатуры вводятся числа, пока не будет введен 0.
Подсчитать сумму всех нечетных положительных чисел.
*/

namespace H2E3_SumOfOddPositiveNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new Numbers()
            {
                Values = ConsoleUtils.InputData()
            };
            ConsoleUtils.OutputData(numbers);
        }
    }
}