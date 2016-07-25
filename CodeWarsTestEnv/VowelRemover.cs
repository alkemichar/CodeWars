using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWarsTestEnv
{
    public class VowelRemover
    {
        public static string Shortcut(string input)
        {
            string filteredWord = "";
            var charArr = input.ToCharArray();
            for (int i = 0; i < charArr.Length; i++) {
                char ch = charArr[i];
                if (ch != 'a' && ch != 'e' && ch != 'i' && ch != 'o' && ch != 'u') {
                    filteredWord += ch;
                }
            }
            return filteredWord;
        }

        public static string ShortcutTheBest(string input)
        {
            return Regex.Replace(input, "[aeiou]", "");
        }

        public static string ShortcutTheBest2(string input)
        {
            return String.Concat(input.Where(c => !"aeiou".Contains(c)));
        }
    }
}
