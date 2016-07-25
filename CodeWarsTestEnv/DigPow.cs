using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTestEnv
{
    /*  Description:
    --------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Some numbers have funny properties. For example:
            89 --> 8¹ + 9² = 89 * 1
            695 --> 6² + 9³ + 5⁴= 1390 = 695 * 2
            46288 --> 4³ + 6⁴+ 2⁵ + 8⁶ + 8⁷ = 2360688 = 46288 * 51     
        Given a positive integer n written as abcd... (a, b, c, d... being digits) and a positive integer p we want to find a positive integer k, if it exists, such as the sum of the digits of n taken to the successive powers of p is equal to k * n. In other words:
            Is there an integer k such as : (a ^ p + b ^ (p+1) + c ^(p+2) + d ^ (p+3) + ...) = n * k
        If it is the case we will return k, if not return -1.
        Note: n, p will always be given as strictly positive integers.
            digPow(89, 1) should return 1 since 8¹ + 9² = 89 = 89 * 1
            digPow(92, 1) should return -1 since there is no k such as 9¹ + 2² equals 92 * k
            digPow(695, 2) should return 2 since 6² + 9³ + 5⁴= 1390 = 695 * 2
            digPow(46288, 3) should return 51 since 4³ + 6⁴+ 2⁵ + 8⁶ + 8⁷ = 2360688 = 46288 * 51
    --------------------------------------------------------------------------------------------------------------------------------------------------------------------
    */
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
