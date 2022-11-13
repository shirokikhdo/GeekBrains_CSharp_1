using System.Text.RegularExpressions;

namespace H5E1_LoginValidation
{
    public class Validator
    {
        public string InputLogin { get; set; }
        public int MinChars { get; set; }
        public int MaxChars { get; set; }

        public Validator(string inputLogin, int minChars, int maxChars)
        {
            InputLogin = inputLogin;
            MinChars = minChars;
            MaxChars = maxChars;
        }

        public bool Validate()
        {
            var cond1 = InputLogin.Length >= MinChars && InputLogin.Length <= MaxChars;
            bool cond2 = true;
            foreach(var c in InputLogin)
            {
                if (!char.IsLetterOrDigit(c)) cond2 = false;
            }
            var cond3 = char.IsLetter(InputLogin[0]);
            return cond1 && cond2 && cond3;
        }

        public bool ValidateRegex()
        {
            var cond = @"^[a-zA-Z]{1}[a-zA-Z0-9]{1,9}$";
            var regex = new Regex(cond);
            var result = regex.IsMatch(InputLogin);
            return result;
        }
    }
}