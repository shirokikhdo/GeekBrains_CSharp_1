using System;
using System.IO;

namespace H6E4_WriteAndRead
{
    public class FileStreamUtils
    {
        public static byte[] Read(string fileName)
        {
            if (!File.Exists(fileName)) throw new Exception($"Файл {fileName} не существует!");
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                var result = new byte[fs.Length];
                for (int i = 0; i < fs.Length; i++)
                {
                    result[i] = (byte)fs.ReadByte();
                }
                return result;
            }
        }

        public static void Write(string fileName, long size)
        {
            using(var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                for (int i = 0; i < size; i++)
                {
                    fs.WriteByte(0);
                }
            }
        }
    }
}