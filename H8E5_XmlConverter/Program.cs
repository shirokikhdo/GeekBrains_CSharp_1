/*
Написать программу - преобразователь из CSV в XML-файл с информацией о студентах (6 урок). 
*/

namespace H8E5_XmlConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var csvName = "students.csv";
            var students = Student.CreateCollection(100);
            FileUtils.Save(csvName, students);
            var result = FileUtils.Load(csvName);
            Serializer.SerializeData(result);
        }
    }
}