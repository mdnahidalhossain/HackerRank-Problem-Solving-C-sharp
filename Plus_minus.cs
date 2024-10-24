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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double pos = 0;
        double neg = 0;
        double zero = 0;
        
        double decRatio1 = 0;
        double decRatio2 = 0;
        double decRatio3 = 0;
    
        for (int i = 0; i < arr.Count; i++) {
            if (arr[i] > 0) {
                pos +=1;
                
                decRatio1 = Math.Round(pos / arr.Count, 6);
                
            }
            else if (arr[i] < 0) {
                neg +=1;
                
                decRatio2 = Math.Round(neg / arr.Count, 6);
                
            }
            
            else if (arr[i] == 0) {
                zero +=1;
                
                decRatio3 = Math.Round(zero / arr.Count, 6);
            }
        }
        
        Console.WriteLine(decRatio1);
        Console.WriteLine(decRatio2);
        Console.WriteLine(decRatio3);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
