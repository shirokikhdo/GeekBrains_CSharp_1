/*
а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
в) Добавить диалог с использованием switch демонстрирующий работу класса.
*/

namespace H3E1_Complex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ComplexStruct struct1;
            ComplexStruct struct2;
            ComplexClass class1;
            ComplexClass class2;
            ConsoleUtils.InputData(out struct1, out struct2, out class1, out class2);
            ConsoleUtils.OutputData(struct1, struct2, class1, class2);
        }
    }
}