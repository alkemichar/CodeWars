using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTestEnv
{
    /*  Duplicate Encoder
    --------------------------------------------------------------------------------------------------------------------------------------------------------------------       
        The goal of this exercise is to convert a string to a new string where each character in the new string is '(' if that character appears only once in the original 
        string, or ')' if that character appears more than once in the original string. Ignore capitalization when determining if a character is a duplicate.

        Examples:
        "din" => "((("
        "recede" => "()()()"
        "Success" => ")())())"
        "(( @" => "))(("
     
        https://www.codewars.com/kata/54b42f9314d9229fd6000d9c
    --------------------------------------------------------------------------------------------------------------------------------------------------------------------
    */
    public static class DuplicateEncoder
    {
        public static string DuplicateEncode(string word)
        {
            char BracketSingle = '(', BracketMultiple = ')';
            List<char> charStorage = new List<char>();
            var charArr = word.ToLower().ToCharArray();            
            for (int i = 0; i <= charArr.Length - 1; i++ ) {
                bool contains = false;
                if (charStorage.Contains(charArr[i])) {
                    charArr[i] = BracketMultiple;
                } else {
                    foreach (char c in word.ToLower().Substring(i + 1, word.Length - (i +1)).ToCharArray()) {
                        if (c == charArr[i]) {
                            contains = true;
                            break;
                        } 
                    }
                    if (contains) {
                        charStorage.Add(charArr[i]);
                        charArr[i] = BracketMultiple;                        
                    } else {
                        charArr[i] = BracketSingle;
                    }
                }
            }
            return new String(charArr);
        }

        public static string TheBest(string word) {
            return new string(word.ToLower().Select(ch => word.ToLower().Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray());
        }
    }
}
