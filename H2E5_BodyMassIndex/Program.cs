/*
а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
нужно ли человеку похудеть, набрать вес или всё в норме.
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
*/

namespace H2E5_BodyMassIndex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person()
            {
                Weight = ConsoleUtils.InputData("массу"),
                Height = ConsoleUtils.InputData("рост")
            };
            ConsoleUtils.OutputData(person);
        }
    }
}