﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTestEnv
{
    class Program
    {
        static void Main(string[] args)
        {
            //var res = DigPow.digPow(695, 2);
            //var res = VowelRemover.Shortcut("codewars");
            //var res = Masify.Maskify("4556364607935616");
            //NameArrayCapping.CapMe(new string[] { "KARLY", "DANIEL", "KELSEY" });
            //NameArrayCapping.CapMe(new string[] { "jo", "nelson", "jurie" });
            //var res = SequenceSum.SumOfN(-5);
            //long[,] lst2 = new long[,] { { 1, 4 }, {10 ,50} };
            //var result = CommonDenominators.convertFrac(lst);
            //var res = Highest2Factors.HighestBiPrimeFac(5,11,1000);
            //var result = BinaryToString.MySolution("0100100001100101011011000110110001101111");
            //var rez = (-0m).ToCurrency("E");
            //var result = DuplicateEncoder.DuplicateEncode("recede");
            var result = TankTruck.TankVol(40, 120, 3500);
        }
    }
}
