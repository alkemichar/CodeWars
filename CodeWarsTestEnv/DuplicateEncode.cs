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
    --------------------------------------------------------------------------------------------------------------------------------------------------------------------
    */
    public static class DuplicateEncoder
    {
        public static string DuplicateEncode(string word)
        {
            return word.ToString();
        }
    }
}
