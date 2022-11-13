using System.Linq;

namespace H5E3_StringComparison
{
    public class Comparer
    {
        public string Value1 { get; set; }
        public string Value2 { get; set; }

        public Comparer(string value1, string value2)
        {
            Value1 = value1;
            Value2 = value2;
        }

        public bool IsTansposition()
        {
            var line1 = string.Join(string.Empty, Value1.OrderBy(x => x));
            var line2 = string.Join(string.Empty, Value2.OrderBy(x => x));
            var result = line1 == line2;
            return result;
        }
    }
}