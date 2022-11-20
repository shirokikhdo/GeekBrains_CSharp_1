/*
Переделать программу Пример использования коллекций для решения следующих задач:
а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
в) отсортировать список по возрасту студента;
г) *отсортировать список по курсу и возрасту студента; 
*/

namespace H6E3_Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fileName = "students.csv";
            var students = Student.CreateCollection(20);
            FileUtils.Save(fileName, students);
            
            var collection = FileUtils.Load(fileName);
            ConsoleUtils.OutputData(collection);
        }
    }
}