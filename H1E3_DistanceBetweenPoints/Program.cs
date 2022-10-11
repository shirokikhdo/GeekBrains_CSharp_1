/*
а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле 
r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
*/

namespace H1E3_DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point()
            {
                X = ConsoleUtils.InputData("x1"),
                Y = ConsoleUtils.InputData("y1")
            };

            var p2 = new Point()
            {
                X = ConsoleUtils.InputData("x2"),
                Y = ConsoleUtils.InputData("y2")
            };

            ConsoleUtils.OutputData(p1, p2);
        }
    }
}