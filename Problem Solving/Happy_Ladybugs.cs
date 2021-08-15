using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Happy_Ladybugs
    {
        public static string happyLadybugs(string b)
        {
            if (b.Where(q => q == '_').ToList().Count == b.Length)
                return "YES";

            var singles = b.GroupBy(p => p).Where(g => g.Count() == 1 && g.Key != '_').Select(g => g.Key).ToList();
            if (singles.Count > 0)
                return "NO";

            if (b.Where(q => q == '_').ToList().Count == 0)
            {
                var charecters = b.GroupBy(p => p).ToList();
                foreach (var item in charecters)
                {
                    var result = b.Select((bc, i) => bc.Equals(item.Key) ? i : -1).Where(i => i != -1).ToList();
                    if (isConsecutive(result) == false)
                        return "NO";
                }

            }

            return "YES";
        }

        public static bool isConsecutive(List<int> input)
        {
            for (int i = 0; i < input.Count - 1; i++)
            {
                if (Math.Abs(input[i] - input[i + 1]) != 1)
                    return false;
            }

            return true;
        }
    }
}
