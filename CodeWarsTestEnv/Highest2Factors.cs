using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTestEnv
{
    public class Highest2Factors
    {
        public static long[] HighestBiPrimeFac(long p1, long p2, long n)
        {
            long maxNumber = 0;
            int i = 1;
            int k1 = 1, k2 = 1;
            while (Math.Pow(p1 ,i) <= n) {
                int j = 1;
                while ((long)(Math.Pow(p1 ,i) * Math.Pow(p2 ,j)) <= n) {
                    if ((long)(Math.Pow(p1, i) * Math.Pow(p2, j)) > maxNumber) { 
                        maxNumber = (long)(Math.Pow(p1, i) * Math.Pow(p2, j));
                        k1 = i;
                        k2 = j;
                    }
                    j++;
                }
                i++;
            }
            return new long[] { maxNumber, k1, k2 };
        }
    }
}
