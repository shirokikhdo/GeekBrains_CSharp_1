namespace H4E4_LoginAndPassword
{
    public class Validator
    {
        private Account _validAccount => Serializer.DeserializeData();
        public string Login { get; set; }
        public string Password { get; set; }
        public int ValidCount = 3;

        public Validator(InputData data)
        {
            Login = data.Login;
            Password = data.Password;
        }

        public bool Validate()
        {
            return Login == _validAccount.Login && Password == _validAccount.Password;
        }
    }
}