namespace H4E3_OneDimensionalArray
{
    public class OneDimensionalArray
    {
        public int Count { get; set; }
        public int Start { get; set; }
        public int Step { get; set; }
        public int[] Value { get; set; }
        public int Sum => _setSum();

        public OneDimensionalArray(int count, int start, int step)
        {
            Count = count;
            Start = start;
            Step = step;
            Value = new int[Count];
            _setArray();
        }

        private void _setArray()
        {
            var current = Start;
            for(var i = 0; i < Count; i++)
            {
                Value[i] = current;
                current += Step;
            }
        }

        public override string ToString()
        {
            var line = string.Join(", ", Value);
            return line;
        }

        private int _setSum()
        {
            var sum = 0;
            for(var i = 0;i < Count; i++)
            {
                sum += Value[i];
            }
            return sum;
        }

        public int[] Inverse()
        {
            var array = new int[Count];
            for(var i = 0; i<Count; i++)
            {
                array[i] = -Value[i];
            }
            return array;
        }

        public int[] Multi(int value)
        {
            var array = new int[Count];
            for(var i =0; i<Count; i++)
            {
                array[i] = Value[i] * value;
            }
            return array;
        }
    }
}