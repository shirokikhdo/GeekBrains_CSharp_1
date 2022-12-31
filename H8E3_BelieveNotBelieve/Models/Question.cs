using System;

namespace H8E3_BelieveNotBelieve.Models
{
    [Serializable]
    public class Question
    {
        public string Text { get; set; }
        public bool TrueFalse { get; set; }

        public Question()
        {

        }

        public Question(string text, bool trueFalse)
        {
            Text = text;
            TrueFalse = trueFalse;
        }
    }
}