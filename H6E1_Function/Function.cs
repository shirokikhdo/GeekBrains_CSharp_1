using System;

namespace H6E1_Function
{
    public class Function
    {
        public static double Square(double a, double x) => a * x * x;

        public static double Sin(double a, double x) => a * Math.Round(Math.Sin(x), 2);
    }
}