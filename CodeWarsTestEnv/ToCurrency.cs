using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTestEnv
{
    /*  Format number as currency using extension method
    --------------------------------------------------------------------------------------------------------------------------------------------------------------------       
        Extension methods have been introduced in C# as a convenient way to extend functionality without introducing new inherited classes.
        For this kata you will write an extension method for decimals called ToCurrency. It should accept single parameter of type string denoting currency prefix. 
        This method should return a string composed of currency prefix and the number itself displayed with 2 decimals. If required number should be rounded. Note 
        that if number is negative minus sign should be added before the currency prefix.
        Examples:
        (0m).ToCurrency("$") should return "$0.00"
        (1.2345m).ToCurrency("$") should return "$1.23"
        (-99.9999m).ToCurrency("$") should return "-$100.00"
    --------------------------------------------------------------------------------------------------------------------------------------------------------------------
    */
    public static class ToCurrencyClass
    {
        public static string ToCurrency(this decimal value, string currency) {
            return (value < 0) ?
                "-" + currency + Math.Round(value, 2, MidpointRounding.AwayFromZero).ToString("#0.00").Remove(0,1) : 
                currency + Math.Round(value, 2, MidpointRounding.AwayFromZero).ToString("#0.00");            
        }

        public static string TheBest(this decimal value, string currencyPrefix) {
            return string.Format("{0}{1}{2:0.00}", value >= 0m ? "": "-", currencyPrefix,  Math.Abs(decimal.Round(value, 2)));
        }
    }
}
