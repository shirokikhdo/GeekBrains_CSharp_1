namespace H2E7_Recursion
{
    public class Array
    {
        public string ArrayAsString = string.Empty;
        public int Sum = 0;
        public int Start { get; set; }
        public int End { get; set; }

        public Array(InputData data)
        {
            Start = data.A;
            End = data.B;
            _setArrayAsString(Start);
            _setSum(Start);
        }

        private void _setArrayAsString(int value)
        {
            if (value <= End)
            {
                if (ArrayAsString == string.Empty) ArrayAsString += value;
                else ArrayAsString += $", {value}";

                _setArrayAsString(value + 1);
            }
        }

        private void _setSum(int value)
        {
            if(value <= End)
            {
                Sum += value;
                _setSum(value + 1);
            }
        }
    }
}