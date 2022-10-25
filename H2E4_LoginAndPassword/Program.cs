/*
 Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
 */

namespace H2E4_LoginAndPassword
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var i = 1;
            Validator validator;
            do
            {
                var data = ConsoleUtils.InputData();
                validator = new Validator(data);
                var result = validator.Validate();
                if (result)
                {
                    ConsoleUtils.OutputData();
                    return;
                }
                else
                {
                    ConsoleUtils.OutputData(validator.ValidCount - i);
                    i++;
                }
            }
            while (i<=validator.ValidCount);
        }
    }
}