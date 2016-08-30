using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTestEnv
{
    /*  Binary to Text (ASCII) Conversion
    --------------------------------------------------------------------------------------------------------------------------------------------------------------------       
        Write a function that takes in a binary string and returns the equivalent decoded text (the text is ASCII encoded).
        Each 8 bits on the binary string represent 1 character on the ASCII table.
        The input string will always be a valid binary string.
        Characters can be in the range from "00000000" to "11111111" (inclusive)
        Note: In the case of an empty binary string your function should return an empty string.
      
       https://www.codewars.com/kata/5583d268479559400d000064
    --------------------------------------------------------------------------------------------------------------------------------------------------------------------
    */
    public class BinaryToString
    {
        public static string MySolution(string binary)
        {
            int i = 0;
            byte[] byteArr = new byte[binary.Length/8];
            while ((i *8) < binary.Length) {
                var byteRep = Convert.ToInt32(binary.Substring((i * 8), 8), 2);
                Byte.TryParse(byteRep.ToString(), out byteArr[i]);                         
                i++;
            }
            return Encoding.ASCII.GetString(byteArr);
        }

        public static string TheBest(string binary) {
            return Encoding.ASCII.GetString( Enumerable.Range(0, binary.Length / 8).Select(i => Convert.ToByte(binary.Substring(8 * i, 8), 2)).ToArray());
        }
    }
}
