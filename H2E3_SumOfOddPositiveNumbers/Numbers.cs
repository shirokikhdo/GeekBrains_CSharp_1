using System.Collections.Generic;

namespace H2E3_SumOfOddPositiveNumbers
{
    public class Numbers
    {
        public List<int> Values { get; set; }
        public int SumOfOddPositiveNumbers => _setSumOfOddPositiveNumbers();

        private int _setSumOfOddPositiveNumbers()
        {
            var sum = 0;
            foreach (var value in Values)
            {
                if (value > 0 && value % 2 == 0) sum += value;
            }
            return sum;
        }

        public override string ToString()
        {
            var line = string.Join(", ", Values);
            return line;
        }
    }
}