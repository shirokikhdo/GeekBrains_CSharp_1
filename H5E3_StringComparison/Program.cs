/*
*Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
Например:
badc являются перестановкой abcd. 
*/

namespace H5E3_StringComparison
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var comparer = ConsoleUtils.InputData();
            ConsoleUtils.OutputData(comparer);
        }
    }
}