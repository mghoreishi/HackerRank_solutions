using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int pickingNumbers(List<int> a)
    {
        List<int> countOfElement = new List<int>();
        var q = a.GroupBy(x => x)
        .Select(g => new { Value = g.Key, Count = g.Count() })
        .OrderByDescending(x => x.Value).ToList();

        for (int i = 0; i < q.Count; i++)
        {
            if (i + 1 != q.Count && Math.Abs(q[i].Value - q[i + 1].Value) == 1)
                countOfElement.Add(q[i].Count + q[i + 1].Count);
            else
                countOfElement.Add(q[i].Count);

        }

        return countOfElement.Max();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
