/*
Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
где m — масса тела в килограммах, h — рост в метрах.
*/

namespace H1E2_BodyMassIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
                Weight = ConsoleUtils.InputData("вес"),
                Height = ConsoleUtils.InputData("рост")
            };
            ConsoleUtils.OutputData(person);
        }
    }
}