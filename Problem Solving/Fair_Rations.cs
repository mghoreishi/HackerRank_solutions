using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Fair_Rations
    {
        public static string fairRations(List<int> B)
        {
            int counter = 0;
            for (int i = 0; i < B.Count - 1; i++)
            {
                if (B[i] % 2 != 0)
                {
                    B[i]++;
                    B[i + 1]++;
                    counter += 2;
                }
            }

            if (B.Where(q => q % 2 != 0).ToList().Count != 0)
                return "NO";
            return counter.ToString();
        }
    }
}
