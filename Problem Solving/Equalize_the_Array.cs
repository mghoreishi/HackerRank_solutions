using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Equalize_the_Array
    {
        public static int equalizeArray(List<int> arr)
        {
            arr.Sort();
            int max = arr[0], c = 1, maxi = 1;
            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i] == max)
                {
                    c++;
                    if (c > maxi)
                    {
                        maxi = c;
                    }
                }
                else
                {
                    max = arr[i];
                    c = 1;
                }
            }
            return arr.Count - maxi;
        }
    }
}
