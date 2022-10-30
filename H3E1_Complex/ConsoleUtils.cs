using System;

namespace H3E1_Complex
{
    public class ConsoleUtils
    {
        public static void InputData(out ComplexStruct complexStruct1, out ComplexStruct complexStruct2, out ComplexClass complexClass1, out ComplexClass complexClass2)
        {
            var random = new Random();
            var im1 = random.Next(-10, 10);
            var re1 = random.Next(-10, 10);
            var im2 = random.Next(-10, 10);
            var re2 = random.Next(-10, 10);
            complexStruct1 = new ComplexStruct(re1, im1);
            complexStruct2 = new ComplexStruct(re2, im2);
            complexClass1 = new ComplexClass(re1, im1);
            complexClass2 = new ComplexClass(re2, im2);
            Console.WriteLine($"Первое комлексное число: {complexStruct1} (структура)");
            Console.WriteLine($"Второе комлексное число: {complexStruct2} (структура)");
            Console.WriteLine($"Первое комлексное число: {complexClass1} (класс)");
            Console.WriteLine($"Второе комлексное число: {complexClass2} (класс)");
        }

        public static void OutputData(ComplexStruct complexStruct1, ComplexStruct complexStruct2, ComplexClass complexClass1, ComplexClass complexClass2)
        {
            Console.WriteLine("\nРезультат:");
            Console.WriteLine("СТРУКТУРА");
            Console.WriteLine($"Сложение: {complexStruct1.Plus(complexStruct2)}");
            Console.WriteLine($"Вычитание: {complexStruct1.Minus(complexStruct2)}");
            Console.WriteLine($"Умножение: {complexStruct1.Multi(complexStruct2)}");
            Console.WriteLine("КЛАСС");
            Console.WriteLine($"Сложение: {complexClass1.Plus(complexClass2)}");
            Console.WriteLine($"Вычитание: {complexClass1.Minus(complexClass2)}");
            Console.WriteLine($"Умножение: {complexClass1.Multi(complexClass2)}");
            Console.ReadKey();
        }
    }
}