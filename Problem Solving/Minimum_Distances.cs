using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Minimum_Distances
    {
        public static int minimumDistances(List<int> a)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                var nextval = a.Where(q => q == a[i]).FirstOrDefault();

                if (Math.Abs(a.IndexOf(a[i]) - a.LastIndexOf(nextval)) != 0)
                    result.Add(Math.Abs(a.IndexOf(a[i]) - a.LastIndexOf(nextval)));
            }
            if (result.Count == 0)
                return -1;
            else
                return result.Min();
        }
    }
}
