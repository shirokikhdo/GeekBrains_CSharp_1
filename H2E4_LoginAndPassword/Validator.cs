namespace H2E4_LoginAndPassword
{
    public class Validator
    {
        private readonly string _validLogin = "root";
        private readonly string _validPassword = "GeekBrains";

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
            return Login == _validLogin && Password == _validPassword;
        }
    }
}