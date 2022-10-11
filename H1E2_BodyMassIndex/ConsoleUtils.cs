using System;

namespace H1E2_BodyMassIndex
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
            Console.WriteLine($"Индекс массы тела - {Math.Round(person.BodyMassIndex, 2)}.");
            Console.ReadKey();
        }
    }
}