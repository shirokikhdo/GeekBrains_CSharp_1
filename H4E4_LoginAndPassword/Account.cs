using System;

namespace H4E4_LoginAndPassword
{
    [Serializable]
    public struct Account
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public Account(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}