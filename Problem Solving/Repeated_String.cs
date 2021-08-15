using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Repeated_String
    {
        public static long repeatedString(string s, long n)
        {
            long m = n / s.Length;
            int r = Convert.ToInt32(n % s.Length);

            return s.Count(f => (f == 'a')) * m + s.Substring(0, r).Count(f => (f == 'a'));

        }
    }
}
