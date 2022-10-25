namespace H2E4_LoginAndPassword
{
    public class InputData
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public InputData(string login, string password)
        {
            Login = login; 
            Password = password;
        }
    }
}