using System;
using System.IO;
using System.Xml.Serialization;

namespace H4E5_TwoDimensionalArray
{
    public class Serializer
    {
        public static void SerializeData(TwoDimensionalArray array)
        {
            var serializer = new XmlSerializer(typeof(TwoDimensionalArray));
            using (var stream = new FileStream($"{nameof(TwoDimensionalArray)}.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, array);
            }
            ConsoleUtils.Pause("Сериализация завершена. Нажмите любую клавишу для продолжения");
        }

        public static TwoDimensionalArray DeserializeData()
        {
            TwoDimensionalArray array = null;
            try
            {
                var file = $"{nameof(TwoDimensionalArray)}.xml";
                if (!File.Exists(file)) throw new Exception($"Файл {nameof(TwoDimensionalArray)}.xml не найден!");
                var serializer = new XmlSerializer(typeof(TwoDimensionalArray));
                using (var stream = new FileStream(file, FileMode.Open))
                {
                    array = (TwoDimensionalArray)serializer.Deserialize(stream);
                    array.SetArrayFromString();
                    ConsoleUtils.Pause("Десериализация завершена. Нажмите любую клавишу для продолжения");
                    return array;
                }
            }
            catch(Exception e)
            {
                ConsoleUtils.Pause($"{e.Message}\n{e.StackTrace}");
            }
            return array;
        }
    }
}