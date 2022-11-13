using System;
using System.Collections.Generic;
using System.Linq;

namespace H5E4_Students
{
    public class Student
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Grade1 { get; set; }
        public int Grade2 { get; set; }
        public int Grade3 { get; set; }
        public double AverageGrade => _setAverageGrade();

        public Student(Random random)
        {
            Surname = Guid.NewGuid().ToString();
            Name = Guid.NewGuid().ToString();
            Grade1 = random.Next(2, 6);
            Grade2 = random.Next(2, 6);
            Grade3 = random.Next(2, 6);
        }

        private double _setAverageGrade()
        {
            var value = Math.Round((Grade1 + Grade2 + Grade3) / 3.0, 2);
            return value;
        }

        public override string ToString()
        {
            var line = $"{Surname} {Name} {Grade1} {Grade2} {Grade3}";
            return line;
        }

        public static Dictionary<double, List<Student>> GetWorstStudents(List<Student> students)
        {
            var dict = new Dictionary<double, List<Student>>();
            var groups = students.GroupBy(x => x.AverageGrade).OrderBy(x => x.Key).ToList();
            for(var i = 0; i < 3; i++)
            {
                dict.Add(groups[i].Key, groups[i].ToList());
            }
            return dict;
        }
    }
}