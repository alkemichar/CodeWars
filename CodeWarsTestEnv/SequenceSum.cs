using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTestEnv
{
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
