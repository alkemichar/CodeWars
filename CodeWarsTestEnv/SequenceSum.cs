using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTestEnv
{
    /*  SequenceSum
   --------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Sum_of_n (or SequenceSum.sumOfN in Java, SequenceSum.SumOfN in C#) takes an integer n and returns a List (an Array in Java/C#) of length abs(n) + 1. 
        The List/Array contains the numbers in the arithmetic series produced by taking the sum of the consecutive integer numbers from 0 to n inclusive.
            n can also be 0 or a negative value.
        Wikipedia reference for abs value is available: https://en.wikipedia.org/wiki/Absolute_value.
     
        Example:
            5 -> [0, 1, 3, 6, 10, 15]
            -5 -> [0, -1, -3, -6, -10, -15]
            7 -> [0, 1, 3, 6, 10, 15, 21, 28]
      
        https://www.codewars.com/kata/5436f26c4e3d6c40e5000282
   --------------------------------------------------------------------------------------------------------------------------------------------------------------------
    */
    public static class SequenceSum
    {
        public static int[] SumOfN(int n)
        {
            int[] result = new int[Math.Abs(n) + 1];            
            int direction = (n >= 0) ? 1 : -1;

            result[0] = 0;
            for (int i = 1, j = direction; i < Math.Abs(n) + 1; i++, j += direction) {
                result[i] = result[i - 1] + j;
            }
            return result;
        }
    }
}
