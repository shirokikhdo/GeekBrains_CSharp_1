using System;
using System.IO;

namespace H6E4_WriteAndRead
{
    public class BinaryReaderUtils
    {
        public static int[] Read(string fileName)
        {
            if (!File.Exists(fileName)) throw new Exception($"Файл {fileName} не существует!");
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                var result = new int[fs.Length / 4];
                using(var br = new BinaryReader(fs))
                {
                    for (int i = 0; i < fs.Length / 4; i++)
                    {
                        result[i] = br.ReadInt32();
                    }
                }
                return result;
            }
        }

        public static void Write(string fileName, long size)
        {
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                using (var bw = new BinaryWriter(fs))
                {
                    for (int i = 0; i < size; i++)
                    {
                        bw.Write((byte)0);
                    }
                }
            }
        }
    }
}