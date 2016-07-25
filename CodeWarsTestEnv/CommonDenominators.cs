using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTestEnv
{
    public static class CommonDenominators
    {
        public static string convertFrac(long[,] lst)
        {
            long multiplyResult = 1;            
            var nominators = _getDenominatorsNumerators(lst, false);
            var denominators = _getDenominatorsNumerators(lst, true);
                       
            foreach (var denom in denominators) {
                multiplyResult *= denom;
            }

            multiplyResult = GCD(multiplyResult, denominators);
            var newNominators = new int[nominators.Length];
            for (int i = 0; i < nominators.Length; i++) {
                newNominators[i] = (int)((multiplyResult / denominators[i]) * nominators[i]);   
            }

            StringBuilder sb = new StringBuilder();
            long tempMultiplyResult = multiplyResult;
            bool exit = false;
            bool hasDivider = true;
            while (!exit) {
                foreach (int prim in new int[] { 7,5,3,2 }) {
                    hasDivider = true;
                    if (tempMultiplyResult % prim == 0) {
                        tempMultiplyResult /= prim;
                        for (int i = 0; i < denominators.Length; i++) {
                            if (newNominators[i] % prim != 0) {
                                tempMultiplyResult = multiplyResult;
                                hasDivider = false;
                                break;
                            }
                        }
                    } else {
                        hasDivider = false;
                    }
                    if (hasDivider) {
                        multiplyResult = tempMultiplyResult;
                        for (int i = 0; i < newNominators.Length; i++) {
                            newNominators[i] = newNominators[i] / prim;
                        }
                        break;
                    }
                    if (prim == 2 && !hasDivider)
                        exit = true;
                }
            }

            for (int i = 0; i < denominators.Length; i++) {
                sb.AppendFormat("({0},{1})", (newNominators[i]), (multiplyResult));
            }

            return sb.ToString();
        }

        private static long[] _getDenominatorsNumerators(long[,] lst, bool pIsDenom)
        {            
            long[] result = new long[lst.GetLength(0)];
            for(int i = 0; i < lst.GetLength(0); i ++) {
                result[i] = lst[i, (pIsDenom ? 1 : 0)];
            }
            return result;
        }

        private static long GCD(long multiplyResult, long[] denominators)
        {
            bool deniminated = false;
            long tempMultiplyResult = multiplyResult;
            while (!deniminated) {
                multiplyResult = tempMultiplyResult;
                foreach (int prim in new int[] { 2, 3, 5, 7 }) {
                    if (tempMultiplyResult % prim == 0) {
                        tempMultiplyResult /= prim;
                        foreach (var denom in denominators) {
                            if (tempMultiplyResult % denom != 0) {
                                deniminated = true;
                                break;
                            }
                        }
                        break;
                    }
                    deniminated = true;
                }
            }
            return multiplyResult;
        }
    }
}
