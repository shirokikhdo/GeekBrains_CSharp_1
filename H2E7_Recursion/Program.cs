/*
a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
 */

namespace H2E7_Recursion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var data = ConsoleUtils.InputData();
            var array = new Array(data);
            ConsoleUtils.OutputData(array);
        }
    }
}