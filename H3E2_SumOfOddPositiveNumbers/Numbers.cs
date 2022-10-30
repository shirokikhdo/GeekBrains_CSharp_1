using System.Collections.Generic;

namespace H3E2_SumOfOddPositiveNumbers
{
    public class Numbers
    {
        public List<int> Values { get; set; }
        public int SumOfOddPositiveNumbers => _setSumOfOddPositiveNumbers();

        public Numbers()
        {
            Values = new List<int>();
        }

        public int _setSumOfOddPositiveNumbers()
        {
            var sum = 0;
            foreach (var value in Values)
            {
                if (value > 0 && value % 2 != 0) sum += value;
            };
            return sum;
        }

        public override string ToString()
        {
            var line = string.Join(",", Values);
            return line;
        }
    }
}