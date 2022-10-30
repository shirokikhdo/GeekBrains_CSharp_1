using System;

namespace H3E3_RationalFraction
{
    public class RationalFraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public double Value => _setValue();

        public RationalFraction()
        {

        }
        public RationalFraction(int num, int denom)
        {
            Numerator = num;
            Denominator = denom;
        }

        public static RationalFraction operator+(RationalFraction left, RationalFraction right)
        {
            var frac = new RationalFraction()
            {
                Numerator = left.Numerator*right.Denominator + right.Numerator*left.Denominator,
                Denominator = left.Denominator * right.Denominator
            };
            return frac;
        }

        public static RationalFraction operator -(RationalFraction left, RationalFraction right)
        {
            var frac = new RationalFraction()
            {
                Numerator = left.Numerator * right.Denominator - right.Numerator * left.Denominator,
                Denominator = left.Denominator * right.Denominator
            };
            return frac;
        }

        public static RationalFraction operator *(RationalFraction left, RationalFraction right)
        {
            var frac = new RationalFraction()
            {
                Numerator = left.Numerator * right.Numerator,
                Denominator = left.Denominator * right.Denominator
            };
            return frac;
        }

        public static RationalFraction operator /(RationalFraction left, RationalFraction right)
        {
            var frac = new RationalFraction()
            {
                Numerator = left.Numerator * right.Denominator,
                Denominator = left.Denominator * right.Numerator
            };
            return frac;
        }

        public RationalFraction Simplify()
        {
            var nod = _getNod(Numerator, Denominator);
            var value = new RationalFraction()
            {
                Numerator = Numerator / nod,
                Denominator = Denominator / nod
            };
            return value;
        }

        public override string ToString()
        {
            var line = $"{Numerator}/{Denominator}";
            return line;
        }

        private int _getNod(int left, int right)
        {
            left = Math.Abs(left);
            right = Math.Abs(right);
            while(right != 0)
            {
                var temp = right;
                right = left % right;
                left = temp;
            }
            return left;
        }

        private double _setValue()
        {
            var dNum = (double)Numerator;
            var dDen = (double)Denominator;
            var value = dNum / dDen;
            return Math.Round(value, 2);
        }
    }
}