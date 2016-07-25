using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTestEnv
{
    public class DigPow {
        public static long digPow(int n, int p)
        {
            var intStrLeng = n.ToString().Length;
            int endExp = p + intStrLeng - 1;

            long bigNumb = 0;
            for (int i = 1; i <= intStrLeng; i++) {
                double number = (n % Math.Pow(10, i)) / (Math.Pow(10, i - 1));
                bigNumb += (long)Math.Pow(Math.Floor(number), endExp--);
            }

            if ((bigNumb % (long)n) == (long)0) {
                return (bigNumb / n);
            }

            return -1;
        }

        public static long digPowTheBest(int n, int p)
        {
            long number = n.ToString().Select((c, i) => (int)Math.Pow(char.GetNumericValue(c), p + i)).Sum();
            return number % n == 0 ? number / n : -1;
        }
    }
}
