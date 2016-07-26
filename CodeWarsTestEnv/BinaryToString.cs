using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTestEnv
{
    /*  Description:
    --------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Write a function that takes in a binary string and returns the equivalent decoded text (the text is ASCII encoded).
        Each 8 bits on the binary string represent 1 character on the ASCII table.
        The input string will always be a valid binary string.
        Characters can be in the range from "00000000" to "11111111" (inclusive)
        Note: In the case of an empty binary string your function should return an empty string.
    --------------------------------------------------------------------------------------------------------------------------------------------------------------------
    */
    public class BinaryToString
    {
        public static string MySolution(string binary)
        {
            var text = new StringBuilder();
            int i = 0;
            while (i < binary.Length) {
                var strby = binary.Skip(i).Take(8).Select( x => Convert.ToSingle(x));
                //var str = Encoding.ASCII.GetString(strby, 0, strby.Length);
                //text.Append(str);
                i += 8;
            }

            var stsr = Encoding.ASCII.GetString(new byte[8] {0,1,0,0,1,0,0,0});
                       

            return text.ToString();
        }
    }
}
