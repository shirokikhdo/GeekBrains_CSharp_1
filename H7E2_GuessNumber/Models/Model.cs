using System;

namespace H7E2_GuessNumber.Models
{
    public class Model
    {
        public int Result { get; set; }
        public int Steps { get; set; }

        public Model()
        {
            var random = new Random();
            Result = random.Next(1, 100);
            Steps = 0;
        }

        public bool CheckValue(int value)
        {
            Steps++;
            return Result == value;
        }
    }
}