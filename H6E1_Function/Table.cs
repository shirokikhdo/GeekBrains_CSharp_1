using System;

namespace H6E1_Function
{
    public class Table
    {
        public void ShowTable(Func func, double a, double b, double x)
        {
            Console.WriteLine("----- A ----- X ----- Y -----");
            while (a <= b)
            {
                Console.WriteLine($"| {a} | {x} | {func(a, x)} |");
                a++;
            }
            Console.WriteLine("-----------------------------");
        }
    }
}