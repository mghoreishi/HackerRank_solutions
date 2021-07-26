using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class The_Time_in_Words
    {
        public static string timeInWords(int h, int m)
        {
            string[] s = {"",        "one",     "two",       "three",    "four",
                "five",    "six",     "seven",     "eight",    "nine",
                "ten",     "eleven",  "twelve",    "thirteen", "fourteen",
                "fifteen", "sixteen", "seventeen", "eighteen", "nineteen",
                "twenty"};
            string clock = "";
            if (m == 0)
                clock = s[h] + " o' clock";
            else if (m < 15)
                clock = s[m] + " minute" + (m == 1 ? "" : "s") + " past " + s[h];
            else if (m == 15)
                clock = "quarter past " + s[h];
            else if (m <= 20)
                clock = s[m] + " minutes past " + s[h];
            else if (m < 30)
                clock = "twenty " + s[m - 20] + " minutes past " + s[h];
            else if (m == 30)
                clock = "half past " + s[h];
            else if (m < 40)
                clock = "twenty " + s[40 - m] + " minutes to " + s[h + 1];
            else if (m < 45)
                clock = s[60 - m] + " minutes to " + s[h + 1];
            else if (m == 45)
                clock = "quarter to " + s[h + 1];
            else
                clock = s[60 - m] + " minute" + (m == 59 ? "" : "s") + " to " + s[h + 1];

            return clock;
        }


    }
}
