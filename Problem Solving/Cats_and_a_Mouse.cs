using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Solution
    {

        // Complete the catAndMouse function below.
        static string catAndMouse(int x, int y, int z)
        {
            if (Math.Abs(x - z) > Math.Abs(y - z))
                return "Cat B";
            else if (Math.Abs(x - z) < Math.Abs(y - z))
                return "Cat A";
            else
                return "Mouse C";
        }

        static void Main(string[] args)
        {
            

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = catAndMouse(x, y, z);

                Console.WriteLine(result);
            }

           
        }
    }
}
