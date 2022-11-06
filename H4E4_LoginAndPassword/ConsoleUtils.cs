using System;

namespace H4E4_LoginAndPassword
{
    public class ConsoleUtils
    {
        public static InputData InputData()
        {
            Console.Write("Введите логин: ");
            var login = Console.ReadLine();
            Console.Write("Введите пароль: ");
            var password = Console.ReadLine();
            var data = new InputData(login, password);
            return data;
        }

        public static void OutputData()
        {
            Console.WriteLine("\nРезультат:");
            Console.WriteLine("Данные введены корректно!");
            Console.ReadKey();
        }

        public static void OutputData(int count)
        {
            Console.WriteLine("\nРезультат:");
            Console.WriteLine($"Данные введены некорректно! Осталось попыток - {count}\n");
        }
    }
}