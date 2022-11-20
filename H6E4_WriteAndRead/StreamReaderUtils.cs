using System;
using System.IO;

namespace H6E4_WriteAndRead
{
    public class StreamReaderUtils
    {
        public static string Read(string fileName)
        {
            if (!File.Exists(fileName)) throw new Exception($"Файл {fileName} не существует!");
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
               using (var sr = new StreamReader(fs))
                {
                    var result = sr.ReadToEnd();
                    return result;
                }
            }
        }

        public static void Write(string fileName, long size)
        {
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                using (var sw = new StreamWriter(fs))
                {
                    for (int i = 0; i < size; i++)
                    {
                        sw.Write(0);
                    }

                }
            }
        }
    }
}