using System;

namespace H2E6_GoodNumbersCount
{
    public class Array
    {
        public int GoodNumbersCount => _setGoodNumbersCount();
        public TimeSpan Time { get; set; }

        public Array() { }

        private int _setGoodNumbersCount()
        {
            var start = DateTime.Now;

            var count = 0;
            for(var i = 1; i<= 1_000_000_000; i++)
            {
                if (_isGoodNumber(i)) count++;
            }

            var finish = DateTime.Now;
            Time = finish - start;
            return count;
        }

        private bool _isGoodNumber(int i)
        {
            var sum = 0;
            var temp = i;
            while (temp % 10 > 0)
            {
                sum += temp % 10;
                temp = temp / 10;
            }
            var result = sum == 0
                ? false
                : i % sum == 0;
            return result;
        }
    }
}