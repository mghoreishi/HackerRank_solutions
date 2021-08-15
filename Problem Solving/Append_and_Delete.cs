using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Append_and_Delete
    {
        static void Main(String[] args)
        {
            string s = Console.ReadLine();

            string t = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            string result = appendAndDelete(s, t, k);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        public static string appendAndDelete(string s, string t, int k)
        {
            int counter = 0;
            for (int i = 0; i < Math.Min(s.Length, t.Length); i++)
            {
                if (s[i] != t[i])
                {
                    counter = (s.Length - i) + (t.Length - i);
                    break;
                }
            }
            if (counter == 0)
                counter = Math.Abs(s.Length - t.Length);

            int remain = k - counter;
            if (remain == 0)
                return "Yes";
            else if (remain < 0)
                return "No";
            else
            {
                if ((t.Length == s.Length) && (k >= s.Length || (k < s.Length && k % 2 == 0)))
                    return "Yes";
                else if ((t.Length != s.Length))
                {

                    if ((remain == Math.Min(s.Length, t.Length) * 2) || (remain == (Math.Min(s.Length, t.Length) * 2) + 1))
                        return "Yes";
                    else if ((remain < Math.Min(s.Length, t.Length) * 2) && (remain % 2 == 0))
                        return "Yes";
                }
            }

            return "No";
        }

    }
}
