/*
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) *Сделать задание, только вывод организовать в центре экрана.
в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
 */

namespace H1E5_NameSurnameCity
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Дмитрий", "Широких", "Москва");
            ConsoleUtils.OutputData(person);
        }
    }
}