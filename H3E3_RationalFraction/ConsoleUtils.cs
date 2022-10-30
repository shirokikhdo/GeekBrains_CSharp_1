using System;

namespace H3E3_RationalFraction
{
    public class ConsoleUtils
    {
        public static void InputData(out RationalFraction left, out RationalFraction right)
        {
            var random = new Random();
            var num1 = random.Next(-10, 10);
            var denom1 = random.Next(-10, 10);
            var num2 = random.Next(-10, 10);
            var denom2 = random.Next(-10, 10);
            if (denom1 == 0 || denom2 == 0) throw new ArgumentException("Знаменатель не может быть равен 0!");
            left = new RationalFraction(num1, denom1);
            right = new RationalFraction(num2, denom2);
            Console.WriteLine($"Первая дробь {left}");
            Console.WriteLine($"Вторая дробь {right}");
        }

        public static void OutputData(RationalFraction left, RationalFraction right)
        {
            Console.WriteLine("\nРезультат:");
            var plus = left + right;
            Console.WriteLine($"Сложение - {plus}, после упрощения {plus.Simplify()}");
            var minus = left - right;
            Console.WriteLine($"Вычитание - {minus}, после упрощения {minus.Simplify()}");
            var multi = left * right;
            Console.WriteLine($"Умножение - {multi}, после упрощения {multi.Simplify()}");
            var divide = left / right;
            Console.WriteLine($"Деление - {divide}, после упрощения {divide.Simplify()}");
            Console.WriteLine($"Десятичные дроби - {left.Value} и {right.Value}");
            Console.ReadKey();
        }
    }
}