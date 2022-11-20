/*
Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
Использовать массив (или список) делегатов, в котором хранятся различные функции.
б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.
Пусть она возвращает минимум через параметр (с использованием модификатора out). 
*/

using System;

namespace H6E2_FunctionMinimum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double a = 2, b = 7, h = 1;
            var fileName = "data.bin";
            var func = ConsoleUtils.InputData();
            FileUtils.Save(fileName, a, b, h, func);
            var result = FileUtils.Load(fileName, out var minimum);
            Console.WriteLine($"\nРезультат:" +
                $"\nМассив - {string.Join(", ", result)}" +
                $"\nМинимум - {minimum}");
            Console.ReadKey();
        }
    }
}