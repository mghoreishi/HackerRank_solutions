using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Beautiful_Triplets
    {
        public static int beautifulTriplets(int d, List<int> arr)
        {
            arr.Sort();
            int counter = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                var result = arr.Where(q => Math.Abs(q - arr[i]) == d).Select(q => q).ToList();
                int numberMin = result.Where(q => q < arr[i]).ToList().Count;
                int numberMax = result.Where(q => q > arr[i]).ToList().Count;

                counter += numberMax * numberMin;
            }

            return counter;
        }
    }
}
