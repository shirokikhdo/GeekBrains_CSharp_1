using System;

namespace H8E1_DateTimeProperties
{
    public class ConsoleUtils
    {
        public static void OutputData()
        {
            var props = typeof(DateTime).GetProperties();
            Console.WriteLine($"Все свойства структуры {nameof(DateTime)}:");
            foreach (var prop in props)
            {
                Console.WriteLine(prop.Name);
            }
            Console.ReadKey();
        }
    }
}