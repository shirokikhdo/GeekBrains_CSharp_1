using System;

namespace H1E3_DistanceBetweenPoints
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double GetDistance(Point point)
        {
            var distance = Math.Sqrt(Math.Pow(point.X - X, 2) + Math.Pow(point.Y - Y, 2));
            return distance;
        }
    }
}