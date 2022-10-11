/*
Написать программу обмена значениями двух переменных:
а) с использованием третьей переменной;
б) *без использования третьей переменной.
 */

namespace H1E4_Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            var swapper = new Swapper()
            {
                Left = ConsoleUtils.InputData("первое"),
                Right = ConsoleUtils.InputData("второе")
            };

            ConsoleUtils.OutputData(swapper);
        }
    }
}