using System;
using System.IO;
using System.Xml.Serialization;

namespace H4E2_StaticArrayPairs
{
    public class Serializer
    {
        public static void SerializeData(Array array)
        {
            var serializer = new XmlSerializer(typeof(Array));
            using (var stream = new FileStream($"{nameof(Array)}.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, array);
            }
            ConsoleUtils.Pause("Сериализация завершена. Нажмите любую клавишу для продолжения");
        }

        public static Array DeserializeData()
        {
            Array array = null;
            try
            {
                var file = $"{nameof(Array)}.xml";
                if (!File.Exists(file)) throw new Exception($"Файл {nameof(Array)}.xml не найден!");
                var serializer = new XmlSerializer(typeof(Array));
                using (var stream = new FileStream(file, FileMode.Open))
                {
                    array = (Array)serializer.Deserialize(stream);
                }
                ConsoleUtils.Pause("Десериализиация завершена. Нажмите любую клавишу для продолжения");
                return array;
            }
            catch (Exception e)
            {
                ConsoleUtils.Pause($"{e.Message}\n{e.StackTrace}");
            }
            return array;
        }
    }
}