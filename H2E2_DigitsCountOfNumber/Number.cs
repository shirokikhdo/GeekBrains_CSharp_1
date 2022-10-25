namespace H2E2_DigitsCountOfNumber
{
    public class Number
    {
        public int Value { get; set; }
        public int DigitsCount => _setDigitsCount();

        private int _setDigitsCount()
        {
            var i = 1;
            var temp = Value;
            while(temp%10 != temp)
            {
                temp = temp / 10;
                i++;
            }
            return i;
        }
    }
}