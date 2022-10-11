/*
Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
В результате вся информация выводится в одну строчку:
а) используя склеивание;
б) используя форматированный вывод;
в) используя вывод со знаком $.
*/

using System;

namespace H1E1_Form
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
                Name = ConsoleUtils.InputData("Имя"),
                Surname = ConsoleUtils.InputData("Фамилия"),
                Age = ConsoleUtils.InputData("Возраст"),
                Height = ConsoleUtils.InputData("Рост"),
                Weight = ConsoleUtils.InputData("Вес")
            };
            ConsoleUtils.OutputData(person);
        }
    }
}