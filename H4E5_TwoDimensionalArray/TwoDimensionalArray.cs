using System;

namespace H4E5_TwoDimensionalArray
{
    [Serializable]
    public class TwoDimensionalArray
    {
        private int[,] _value;
        public int[] Position = new int[2];
        public int Count { get; set; }
        public int Max => _setMax(ref Position);
        public int Min => _setMin();
        public string StringArray { get; set; }

        public TwoDimensionalArray(int count)
        {
            Count = count;
            _value = new int[Count, Count];
            _setArray();
            StringArray = this.ToString();
        }

        public TwoDimensionalArray()
        {

        }

        private void _setArray()
        {
            var random = new Random();
            for(var i = 0; i < Count; i++)
            {
                for (var j = 0; j < Count; j++)
                {
                    _value[i, j] = random.Next(1, 10);
                }
            }
        }

        public override string ToString()
        {
            var line = string.Empty;
            for (var i = 0; i < Count; i++)
            {
                for (var j = 0; j < Count; j++)
                {
                    if(j != Count - 1)
                    {
                        line += _value[i, j] + " ";
                    }
                    else line += _value[i, j];
                }
                if(i != Count - 1) line += "\n";
            }
            return line;
        }

        public int GetSum()
        {
            var sum = 0;
            for(var i = 0; i < Count; i++)
            {
                for(var j = 0; j < Count; j++)
                {
                    sum += _value[i, j];
                }
            }
            return sum;
        }

        public int GetSum(int value)
        {
            var sum = 0;
            for (var i = 0; i < Count; i++)
            {
                for (var j = 0; j < Count; j++)
                {
                    if(_value[i, j] > value) sum += _value[i, j];
                }
            }
            return sum;
        }

        private int _setMax(ref int[] position)
        {
            var max = _value[0,0];
            for(var i = 0; i < Count; i++)
            {
                for(var j = 0; j < Count; j++)
                {
                    if(_value[i, j] > max)
                    {
                        max = _value[i, j];
                        position[0] = i;
                        position[1] = j;
                    }
                }
            }
            return max;
        }

        private int _setMin()
        {
            var min = _value[0, 0];
            for (var i = 0; i < Count; i++)
            {
                for (var j = 0; j < Count; j++)
                {
                    if (_value[i, j] < min) min = _value[i, j];
                }
            }
            return min;
        }

        public void SetArrayFromString()
        {
            _value = new int[Count, Count];
            var lines = this.StringArray.Split('\n');
            for (var i = 0; i < lines.Length; i++)
            {
                var columns = lines[i].Split(' ');
                for (var j = 0; j < columns.Length; j++)
                {
                    this._value[i, j] = Convert.ToInt32(columns[j]);
                }
            }
        }
    }
}