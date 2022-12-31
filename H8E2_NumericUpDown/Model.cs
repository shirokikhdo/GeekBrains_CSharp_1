namespace H8E2_NumericUpDown
{
    public class Model
    {
        public int Value { get; set; }

        public Model()
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