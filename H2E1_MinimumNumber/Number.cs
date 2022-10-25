namespace H2E1_MinimumNumber
{
    public class Number
    {
        public int FirstValue { get; set; }
        public int SecondValue { get; set; }
        public int ThirdValue { get; set; }
        public int MinValue => _setMinValue();

        private int _setMinValue()
        {
            int result;
            if(FirstValue < SecondValue)
            {
                result = FirstValue > ThirdValue
                    ? ThirdValue
                    : FirstValue;
            }
            else
            {
                result = SecondValue > ThirdValue
                    ? ThirdValue
                    : SecondValue;
            }
            return result;
        }
    }
}