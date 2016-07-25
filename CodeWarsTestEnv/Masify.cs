using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTestEnv
{
    public static class Masify
    {
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
