using System;
using System.Collections.Generic;
using System.Windows;

namespace H7E1_Doubler.Models
{
    public class Model
    {
        public int Value { get; set; }
        public int Steps { get; set; }
        public int Result { get; set; }
        public Stack<int> Stack { get; set; } = new Stack<int>();

        public Model(int result)
        {
            Reset();
            Steps = 0;
            Result = result;
        }

        public void Plus()
        {
            Stack.Push(Value);
            Value += 1;
            Steps++;
        }

        public void Multiply()
        {
            Stack.Push(Value);
            Value *= 2;
            Steps++;
        }

        public void Reset()
        {
            Stack.Push(Value);
            Value = 1;
            Steps++;
        }

        public void Cancel()
        {
            if (Stack.Count > 0)
            {
                Value = Stack.Pop();
            }
        }

        public static int GenerateResult()
        {
            var random = new Random();
            var result = random.Next(5, 10);
            return result;
        }

        public bool CheckValue()
        {
            if(Value == Result)
            {
                MessageBox.Show($"Конец игры!\nВы потратили {Steps} шагов!");
                return false;
            }
            if (Value > Result)
            {
                MessageBox.Show($"Конец игры!\nВаше значение больше результата!");
                return false;
            }
            return true;
        }
    }
}