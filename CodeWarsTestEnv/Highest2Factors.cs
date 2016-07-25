using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTestEnv
{
    /*  Description:
    --------------------------------------------------------------------------------------------------------------------------------------------------------------------
        The numbers 6, 12, 18, 24, 36, 48 have a common property. They have the same two prime factors that are 2 and 3.     
        If we see their prime factorization we will see it more clearly:
            6 = 2 * 3
            12 = 2^2 * 3
            18 = 2 * 3^2
            24 = 2^3 * 3
            36 = 2^2 * 3^2
            48 = 2^4 * 3
        In this case 605 is the highest possible number bellow 1000.
        Make the function highest_biPrimefac(), that receives two primes as arguments and a maximum limit , nMax(found numbers should be less or equal to nMax). 
        The function should output a list with three elements in this order: highest found number, the exponent corresponding to the smaller prime and the exponent 
        for the biggest prime.
        Representing the features for this function:
            highest_biPrimefac(p1, p2, nMax) -------> [max.number, k1, k2]
            max.number = p1^k1 * p2^k2 <= nMax
            p1 < p2 and k1 >= 1, k2 >= 1
        Let's see the cases we have above:
            highest_biPrimefac(2, 3, 50) ------> [48, 4, 1]
            highest_biPrime(5, 11, 1000) ------> [605, 1, 2]
     --------------------------------------------------------------------------------------------------------------------------------------------------------------------
     */
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
