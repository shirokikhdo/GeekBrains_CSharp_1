/*
 Написать метод подсчета количества цифр числа.
 */

namespace H2E2_DigitsCountOfNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var number = new Number()
            {
                Value = ConsoleUtils.InputData()
            };
            ConsoleUtils.OutputData(number);
        }
    }
}