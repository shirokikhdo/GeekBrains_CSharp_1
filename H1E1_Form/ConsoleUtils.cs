using System;

namespace H1E1_Form
{
    public class ConsoleUtils
    {
        public static string InputData(string propName)
        {
            Console.Write($"{propName}: ");
            var value = Console.ReadLine();
            return value;
        }

        public static void OutputData(Person person)
        {
            Console.WriteLine("\nРезультат:");
            Console.WriteLine("Конкатенация - " + person.Name + " " + person.Surname + " " + person.Age + " " + person.Height + " " + person.Weight + ";");
            Console.WriteLine("Форматирование - {0} {1} {2} {3} {4};", person.Name, person.Surname, person.Age, person.Height, person.Weight);
            Console.WriteLine($"Интерполяция - {person.Name} {person.Surname} {person.Age} {person.Height} {person.Weight}.");
            Console.ReadKey();
        }
    }
}