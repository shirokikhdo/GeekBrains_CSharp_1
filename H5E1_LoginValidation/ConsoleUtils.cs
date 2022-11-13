using System;

namespace H5E1_LoginValidation
{
    public class ConsoleUtils
    {
        public static string InputData()
        {
            Console.WriteLine("Введите логин: ");
            var login = Console.ReadLine();
            Console.WriteLine($"Количество символов - {login.Length}");
            return login;
        }

        public static void OutputData(Validator validator)
        {
            Console.WriteLine("\nРезультат:");
            Console.WriteLine($"Проверка корректности логина без регулярных выражений - {validator.Validate()}");
            Console.WriteLine($"Проверка корректности логина с использование регулярных выражений - {validator.ValidateRegex()}");
            Console.ReadKey();
        }
    }
}