/*
Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
Создайте структуру Account, содержащую Login и Password. 
*/

namespace H4E4_LoginAndPassword
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var validAccount = new Account("root", "GeekBrains");
            Serializer.SerializeData(validAccount);

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
            while (i <= validator.ValidCount);
        }
    }
}