using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace H5E4_Students
{
    public class ConsoleUtils
    {
        public static void InputData(int count, List<Student> students)
        {
            Console.WriteLine($"Общее количество учеников - {count}");
            for(var i = 1; i <= count; i++)
            {
                Console.WriteLine(students[i - 1].ToString());
            }
        }

        public static void OutputData(List<Student> students)
        {
            Console.WriteLine("\nРезультат:");
            Console.WriteLine($"Список худших учеников:");
            var sb = new StringBuilder();
            var dict = Student.GetWorstStudents(students);
            foreach(var item in dict)
            {
                var line = $"{item.Key} - {string.Join(", ", item.Value.Select(x=>$"{x.Surname} {x.Name}"))}";
                sb.AppendLine(line);
            }
            Console.WriteLine($"{sb}");
            Console.ReadKey();
        }
    }
}