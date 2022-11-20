/*
Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
*/

using System;

namespace H6E1_Function
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double a = -2, b = 2, x = 10;
            var table = new Table();
            table.ShowTable(Function.Square, a, b, x);
            table.ShowTable(Function.Sin, a, b, x);
            Console.ReadKey();
        }
    }
}