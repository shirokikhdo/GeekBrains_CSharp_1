using System;
using System.Collections.Generic;

namespace H6E3_Collections
{
    public class Student
    {
        public string FirstName;
        public string SecondName;
        public string University;
        public string Faculty;
        public string Department;
        public int Age;
        public int Course;
        public int Group;
        public string City;

        public Student(string firstName, string secondName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            FirstName = firstName;
            SecondName = secondName;
            University = university;
            Faculty = faculty;
            Department = department;
            Age = age;
            Course = course;
            Group = group;
            City = city;
        }

        public override string ToString()
        {
            var line = $"{FirstName} {SecondName} {University} {Faculty} {Department} {Age} {Course} {Group} {City}";
            return line;
        }

        public static List<Student> CreateCollection(int count)
        {
            var result = new List<Student>();
            var random = new Random();
            for(var i = 1; i <= count; i++)
            {
                var firstName = Guid.NewGuid().ToString();
                var secondName = Guid.NewGuid().ToString();
                var university = Guid.NewGuid().ToString();
                var faculty = Guid.NewGuid().ToString();
                var department = Guid.NewGuid().ToString();
                var age = random.Next(18, 26);
                var course = random.Next(1, 6);
                var group = random.Next();
                var city = Guid.NewGuid().ToString();

                var student = new Student(firstName, secondName, university, faculty, department, age, course, group, city);
                result.Add(student);
            }
            return result;
        }
    }
}