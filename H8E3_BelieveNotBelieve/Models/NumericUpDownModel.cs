namespace H8E3_BelieveNotBelieve.Models
{
    public class NumericUpDownModel
    {
        public int Value { get; set; }
        public int Maximum { get; set; }
        public int Minimum { get; set; }

        public NumericUpDownModel()
        {
            Value = 0;
        }

        public void Increment()
        {
            Value++;
        }

        public void Decrement()
        {
            Value--;
        }
    }
}