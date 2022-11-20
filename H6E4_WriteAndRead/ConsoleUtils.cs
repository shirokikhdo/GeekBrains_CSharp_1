using System;

namespace H6E4_WriteAndRead
{
    public class ConsoleUtils
    {
        public static void OutputData(long size)
        {
            Console.WriteLine("Запись файлов при помощи разных потоков:");

            var fileName = $"{nameof(FileStreamUtils)}.bin";
            FileStreamUtils.Write(fileName, size);
            Console.WriteLine($"{fileName} - файл создан");
            Console.WriteLine($"{string.Join(", ", FileStreamUtils.Read(fileName))}");

            fileName = $"{nameof(BufferedStreamUtils)}.bin";
            BufferedStreamUtils.Write(fileName, size);
            Console.WriteLine($"{fileName} - файл создан");
            Console.WriteLine($"{string.Join(", ", BufferedStreamUtils.Read(fileName))}");

            fileName = $"{nameof(StreamReaderUtils)}.bin";
            StreamReaderUtils.Write(fileName, size);
            Console.WriteLine($"{fileName} - файл создан");
            Console.WriteLine($"{StreamReaderUtils.Read(fileName)}");

            fileName = $"{nameof(BinaryReaderUtils)}.bin";
            BinaryReaderUtils.Write(fileName, size);
            Console.WriteLine($"{fileName} - файл создан");
            Console.WriteLine($"{string.Join(", ", BinaryReaderUtils.Read(fileName))}");

            Console.ReadKey();
        }
    }
}