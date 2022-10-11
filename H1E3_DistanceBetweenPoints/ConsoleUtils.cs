using System;

namespace H1E3_DistanceBetweenPoints
{
    public class ConsoleUtils
    {
        public static double InputData(string coord)
        {
            Console.Write($"Введите {coord}: ");
            var value = double.Parse(Console.ReadLine());
            return value;
        }

        public static void OutputData(Point p1, Point p2)
        {
            Console.WriteLine("\nРезульат:");
            Console.WriteLine($"Без использования метода - {string.Format("{0:F2}", Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2)))};");
            Console.WriteLine($"С использованием метода - {string.Format("{0:F2}", p1.GetDistance(p2))}.");
            Console.ReadKey();
        }
    }
}