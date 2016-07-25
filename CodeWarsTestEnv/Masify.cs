using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTestEnv
{
    public static class Masify
    {
        /*  Description:
       --------------------------------------------------------------------------------------------------------------------------------------------------------------------
            Usually when you buy something, you're asked whether your credit card number, phone number or answer to your most secret question is still correct. 
            However, since someone could look over your shoulder, you don't want that shown on your screen. Instead, we mask it.
            Your task is to write a function maskify, which changes all but the last four characters into '#'.

            Examples
                Kata.Maskify('4556364607935616'); // should return "############5616"
                Kata.Maskify('64607935616');      // should return "#######5616"
                Kata.Maskify('1');                // should return "1"
                Kata.Maskify('');                 // should return ""

                // "What was the name of your first pet?"
                Kata.Maskify('Skippy');                                   // should return "##ippy"
                Kata.Maskify('Nananananananananananananananana Batman!'); // should return "####################################man!"
       --------------------------------------------------------------------------------------------------------------------------------------------------------------------
        */
        public static string Maskify(string cc)
        {
            var strArr = cc.ToArray();
            if (cc.Length > 4) {
                for (int i = 0; i < (cc.Length - 4); i++) {
                    strArr[i] = '#';
                }
                return new string(strArr);
            } else {
                return cc;
            }
        }
        public static string MaskifyBetter(string cc) {
            var strArr = cc.ToArray();
            for (int i = 0; i < (cc.Length - 4); i++) {
                strArr[i] = '#';
            }
            return new string(strArr);
        }

        public static string MaskifyTheBest(string cc) {
            return cc.Substring(cc.Length < 4 ? 0 : cc.Length - 4).PadLeft(cc.Length, '#');
        }
    }

}
