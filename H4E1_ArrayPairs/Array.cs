using System;
using System.Collections.Generic;

namespace H4E1_ArrayPairs
{
    public class Array
    {
        public int Start { get; set; }
        public int End { get; set; }
        public int Count { get; set; } 
        public int[] Value { get; set; }

        public Array(int count, int start, int end)
        {
            Start = start;
            End = end;
            Count = count;
            Value = new int[Count];
            _setArray();
        }

        public override string ToString()
        {
            var line = string.Join(", ", Value);
            return line;
        }

        private void _setArray()
        {
            var random = new Random();
            for(var i = 0; i < Count; i++)
            {
                Value[i] = random.Next(Start, End);
            }
        }

        public List<KeyValuePair<int, int>> GetValidPairs()
        {
            var pairs = new List<KeyValuePair<int, int>>();
            for(var i = 0; i < Count - 1; i++)
            {
                var cond1 = Value[i]%3 == 0 & Value[i+1]%3!=0;
                var cond2 = Value[i] % 3 != 0 & Value[i + 1] % 3 == 0;
                var cond = cond1 | cond2;
                if (cond)
                {
                    var pair = new KeyValuePair<int, int>(Value[i], Value[i+1]);
                    pairs.Add(pair);
                }
            }
            return pairs;
        }
    }
}