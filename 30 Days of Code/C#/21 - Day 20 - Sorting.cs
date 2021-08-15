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



using System;

class Solution {
    static void Main(String[] args) {
        int numberInput = Convert.ToInt32(Console.ReadLine());

        string[] n = Console.ReadLine().Split(' ');
        int[] array = Array.ConvertAll(n, Int32.Parse);
        
        // Write Your Code Here
        int numberOfSwaps = 0;

        for (int i = 0; i < numberInput; i++) {
            for (int j = 0; j < numberInput - 1; j++) {
                if (array[j] > array[j + 1]) {
                    Array.Reverse(array, j, 2);
                    numberOfSwaps++;
                }
            }

            if (numberOfSwaps == 0) {
                break;
            }
        }

        int firstPosition = array[0];
        int lastPosition = array[array.Length - 1];

        Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
        Console.WriteLine($"First Element: {firstPosition}");
        Console.WriteLine($"Last Element: {lastPosition}");
    }
}
