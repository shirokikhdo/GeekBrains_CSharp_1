using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace H5E2_Message
{
    public class Message
    {
        public static string GetWordsWhereLetterCountMoreThan(string msg)
        {
            var cond = @"\w{5,}";
            var matches = _getStringMatches(msg, cond);
            var result = string.Join(", ", matches);
            return result;
        }

        public static string GetWordsWhereLastLetterIsNot(string msg, char c)
        {
            var cond = @"\w+[a-юА-Ю]\b";
            var matches = _getStringMatches(msg, cond);
            var result = string.Join(", ", matches);
            return result;
        }

        public static string GetLongestWord(string msg)
        {
            var cond = @"\w+\b";
            var matches = _getStringMatches(msg, cond);
            var result = matches.OrderBy(x=>x.Length).Last();
            return result;
        }

        public static StringBuilder GetLongestWords(string msg)
        {
            var cond = @"\w+\b";
            var matches = _getStringMatches(msg, cond);
            var sb = new StringBuilder();
            var group = matches.GroupBy(x => x.Length).OrderBy(x=>x.Key).Last();
            foreach(var item in group)
            {
                sb.AppendLine(item);
            }
            return sb;
        }

        public static Dictionary<string, int> TextFrequencyAnalysis(string[] words, string msg)
        {
            var cond = @"\w+\b";
            var wordsInMsg = _getStringMatches(msg, cond);
            var dict = new Dictionary<string, int>();
            foreach(var word in wordsInMsg)
            {
                if (words.Contains(word))
                {
                    if (dict.ContainsKey(word)) dict[word]++;
                    else dict.Add(word, 1);
                }
            }
            return dict;
        }

        private static List<string> _getStringMatches(string message, string condition)
        {
            var result = new List<string>();
            var regex = new Regex(condition);
            var matches = regex.Matches(message);
            foreach (var obj in matches)
            {
                var match = obj as Match;
                result.Add(match.Value);
            }
            return result;
        }
    }
}