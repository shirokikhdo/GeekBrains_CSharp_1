/*
Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет
строка от 2 до 10 символов,
содержащая только буквы латинского алфавита или цифры,
при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) **с использованием регулярных выражений.
*/

namespace H5E1_LoginValidation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = ConsoleUtils.InputData();
            var validator = new Validator(input, 2, 10);
            ConsoleUtils.OutputData(validator);
        }
    }
}