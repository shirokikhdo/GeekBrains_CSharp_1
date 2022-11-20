using System;
using System.IO;

namespace H6E4_WriteAndRead
{
    public class BufferedStreamUtils
    {
        public static byte[] Read(string fileName)
        {
            if (!File.Exists(fileName)) throw new Exception($"Файл {fileName} не существует!");
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                var countPart = 4;
                var bufsize = (int)(fs.Length / countPart);
                var result = new byte[fs.Length];
                using(var bs = new BufferedStream(fs, bufsize))
                {
                    for (int i = 0; i < countPart; i++)
                    {
                        bs.Read(result, 0, bufsize);
                    }
                    return result;
                }
            }
        }

        public static void Write(string fileName, long size)
        {
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                var countPart = 4;
                var bufsize = (int)(size / countPart);
                var buffer = new byte[size];
                using(var bs = new BufferedStream(fs, bufsize))
                {
                    for (int i = 0; i < countPart; i++)
                    {
                        bs.Write(buffer, 0, bufsize);
                    }
                }             
            }
        }
    }
}