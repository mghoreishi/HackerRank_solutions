using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Electronics_Shop
    {
        public static void Main(string[] args)
        {
            string[] bnm = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
            ;

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
            ;
            /*
             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
             */

            int moneySpent = getMoneySpent(keyboards, drives, b);

            Console.WriteLine(moneySpent);

            Console.ReadLine();


        }



        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            keyboards = keyboards.OrderByDescending(q => q).ToArray();
            List<int> resultSum = new List<int>();
            for (int i = 0; i < keyboards.Length; i++)
            {
                int remainCoset = b - keyboards[i];
                var possibleDrivers = drives.ToList().Where(a => a <= remainCoset).ToList();
                if (possibleDrivers.Count != 0)
                {
                    int driver = possibleDrivers.OrderByDescending(a => a).FirstOrDefault();
                    resultSum.Add(driver + keyboards[i]);
                }
            }

            if (resultSum.Count != 0)
            {
                return resultSum.OrderByDescending(q => q).FirstOrDefault();

            }
            return -1;
        }

    }
}
