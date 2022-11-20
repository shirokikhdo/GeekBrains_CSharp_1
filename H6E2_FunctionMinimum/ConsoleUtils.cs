using System;
using System.Reflection;

namespace H6E2_FunctionMinimum
{
    public class ConsoleUtils
    {
        public static Func InputData()
        {
            Console.WriteLine("Введите индекс функции, результат которой хотите увидеть:");
            var funcs = Assembly.GetExecutingAssembly()
                .GetType(typeof(Function).FullName)
                .GetMethods(BindingFlags.Public | BindingFlags.Static);
            for(var i = 0; i < funcs.Length; i++)
            {
                Console.WriteLine($"[{i}] - {funcs[i].Name}");
            }
            var selection = int.Parse(Console.ReadLine());
            var result = funcs[selection].CreateDelegate(typeof(Func)) as Func;
            return result;
        }
    }
}