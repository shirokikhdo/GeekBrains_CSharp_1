using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace H6E3_Collections
{
    public class FileUtils
    {
        public static void Save(string fileName, List<Student> students)
        {
            var result = new StringBuilder();
            foreach (var student in students)
            {
                var line = $"{student.FirstName};" +
                    $"{student.SecondName};" +
                    $"{student.University};" +
                    $"{student.Faculty};" +
                    $"{student.Department};" +
                    $"{student.Age};" +
                    $"{student.Course};" +
                    $"{student.Group};" +
                    $"{student.City}";
                result.AppendLine(line);
            }
            File.WriteAllText(fileName, result.ToString());
        }

        public static List<Student> Load(string fileName)
        {
            if (!File.Exists(fileName)) throw new Exception($"Файл {fileName} не существует!");
            var result = new List<Student>();
            using(var sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    try
                    {
                        var splitLine = sr.ReadLine().Split(';');
                        var student = new Student(splitLine[0],
                            splitLine[1],
                            splitLine[2],
                            splitLine[3],
                            splitLine[4],
                            int.Parse(splitLine[5]),
                            int.Parse(splitLine[6]),
                            int.Parse(splitLine[7]),
                            splitLine[8]);
                        result.Add(student);
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Ошибка при формировании студента!");
                    }
                }
            }
            return result;
        }
    }
}