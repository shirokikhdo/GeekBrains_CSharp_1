using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace H8E5_XmlConverter
{
    public class Serializer
    {
        public static void SerializeData(List<Student> students)
        {
            var serializer = new XmlSerializer(typeof(List<Student>));
            using (var stream = new FileStream($"Students.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, students);
            }
        }
    }
}