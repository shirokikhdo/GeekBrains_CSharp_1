using System;
using System.Collections.Generic;
using System.Linq;

namespace H6E3_Collections
{
    public class ConsoleUtils
    {
        public static void OutputData(List<Student> students)
        {
            Console.WriteLine($"Всего студентов: {students.Count}");
            Console.WriteLine($"Количество студентов учащихся на 5 и 6 курсах: {students.Where(x=>x.Course > 4).Count()}");
            Console.WriteLine($"Количество студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив): {string.Join(", ", students.Where(x => x.Age >= 18 && x.Age <= 20).GroupBy(x => x.Course).OrderBy(x=>x.Key).Select(x => $"Курс - {x.Key} Количество - {x.ToList().Count}"))}");
            Console.WriteLine("Отсортированный список студентов по возрасту:");
            Console.WriteLine(string.Join("\n", students.OrderBy(x=>x.Age)));
            Console.WriteLine("Отсортированный список студентов по курсу и возрасту:");
            Console.WriteLine(string.Join("\n", students.OrderBy(x => x.Course).ThenBy(x=>x.Age)));
            Console.ReadKey();
        }
    }
}