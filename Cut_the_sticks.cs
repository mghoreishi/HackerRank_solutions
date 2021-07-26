using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Cut_the_sticks
    {
        public static List<int> cutTheSticks(List<int> arr)
        {
            List<int> result = new List<int>();
            while (arr.Any(q => q != 0))
            {
                result.Add(arr.Where(q => q != 0).Count());
                int min = arr.Where(q => q != 0).Min();
                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] != 0)
                        arr[i] = arr[i] - min;
                }

            }

            return result;
        }
    }
}
