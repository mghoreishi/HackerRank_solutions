using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Extra_Long_Factorials
    {
        public static void extraLongFactorials(int n)
        {
            System.Numerics.BigInteger res = n;
            n--;
            while (n > 1)
            {
                res *= n;
                n--;
            }
            Console.WriteLine(res);
        }
    }
}
