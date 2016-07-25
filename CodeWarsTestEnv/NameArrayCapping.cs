using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTestEnv
{
    public static class NameArrayCapping
    {
        public static string[] CapMe(string[] strings)
        {
            return strings.Select(p => Char.ToUpper(p.ToCharArray().FirstOrDefault()) + new string(p.Skip(1).Select(k => Char.ToLower(k)).ToArray())).ToArray();
        }

        public static string[] CapMeTheBest(string[] strings)
        {
            return strings.Select(x => x.First().ToString().ToUpper() + x.Substring(1).ToLower()).ToArray();
        }
    }
}
