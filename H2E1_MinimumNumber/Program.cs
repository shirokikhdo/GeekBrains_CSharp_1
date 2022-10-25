/*
 Написать метод, возвращающий минимальное из трёх чисел.
 */

namespace H2E1_MinimumNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var number = new Number()
            {
                FirstValue = ConsoleUtils.InputData("первое"),
                SecondValue = ConsoleUtils.InputData("второе"),
                ThirdValue = ConsoleUtils.InputData("третье")
            };
            ConsoleUtils.OutputData(number);
        }
    }
}