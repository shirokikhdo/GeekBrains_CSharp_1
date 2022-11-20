using System;
using System.Collections.Generic;
using System.IO;

namespace H6E2_FunctionMinimum
{
    public class FileUtils
    {
        public static void Save(string fileName, double a, double b, double h, Func func)
        {
            if(File.Exists(fileName)) File.Delete(fileName);
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                using (var bw = new BinaryWriter(fs))
                {
                    var x = a;
                    while(x <= b)
                    {
                        bw.Write(func(x));
                        x += h;
                    }
                }
            }
        }

        public static List<double> Load(string fileName, out double minimum)
        {
            if (!File.Exists(fileName)) throw new Exception($"Файл {fileName} не существует!");
            var result = new List<double>();
            using(var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using(var br = new BinaryReader(fs))
                {
                    minimum = double.MaxValue;
                    double d;
                    for (var i = 0; i < fs.Length / sizeof(double); i++)
                    {
                        d = br.ReadDouble();
                        result.Add(d);
                        if (d < minimum) minimum = d;
                    }
                    return result;
                }
            }
        }
    }
}