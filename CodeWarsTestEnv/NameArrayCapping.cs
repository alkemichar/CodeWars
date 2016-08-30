using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTestEnv
{
    public static class NameArrayCapping
    {
        /*  Name Array Capping
       --------------------------------------------------------------------------------------------------------------------------------------------------------------------
            Create a method that accepts an array of names, and returns an array of each name with its first letter capitalized.
         
            example
                Kata.CapMe([new string[]{"jo", "nelson", "jurie"}) // returns string[]{"Jo", "Nelson", "Jurie"}
                Kata.CapMe([new string[]{"KARLY", "DANIEL", "KELSEY"}) // returns string[]{"Karly", "Daniel", "Kelsey"}
          
            https://www.codewars.com/kata/5356ad2cbb858025d800111d
       --------------------------------------------------------------------------------------------------------------------------------------------------------------------
        */
        public static string[] CapMe(string[] strings)
        {
            return strings.Select(p => Char.ToUpper(p.ToCharArray().FirstOrDefault()) + new string(p.Skip(1).Select(k => Char.ToLower(k)).ToArray())).ToArray();
        }

        public static string[] CapMeTheBest(string[] strings)
        {
            return strings.Select(x => x.First().ToString().ToUpper() + x.Substring(1).ToLower()).ToArray();
        }
    }
}
