using System;

namespace H2E5_BodyMassIndex
{
    public class ConsoleUtils
    {
        public static double InputData(string propName)
        {
            Console.Write($"Введите {propName}: ");
            var value = double.Parse(Console.ReadLine());
            return value;
        }

        public static void OutputData(Person person)
        {
            Console.WriteLine("\nРезультат:");
            Console.WriteLine($"Индекс массы тела составляет {person.BodyMassIndex}\n{person.Сonclusion}");
            Console.ReadKey();
        }
    }
}