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
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        int birdType1 = 0;
        int birdType2 = 0;
        int birdType3 = 0;
        int birdType4 = 0;
        int birdType5 = 0;
        
        int value = 0;
        
        for (int i=0; i<arr.Count; i++) {
            if (arr[i] == 1) {
                birdType1++;
            }
            
            else if (arr[i] == 2) {
                birdType2++;
            }
            
            else if (arr[i] == 3) {
                birdType3++;
            }
            
            else if (arr[i] == 4) {
                birdType4++;
            }
            
            else if (arr[i] == 5) {
                birdType5++;
            }
        }
        
        if (birdType1 >= birdType2 && birdType1 >= birdType3 && birdType1 >= birdType4 && birdType1 >= birdType5) {
            value = 1;
        }
        
        else if (birdType2 > birdType1 && birdType2 >= birdType3 && birdType2 >= birdType4 && birdType2 >= birdType5) {
            
            value = 2;
        }
        
        else if (birdType3 > birdType1 && birdType3 > birdType2 && birdType3 >= birdType4 && birdType3 >= birdType5) {
            
            value = 3;
        }
        
        else if (birdType4 > birdType1 && birdType4 > birdType2 && birdType4 > birdType3 && birdType4 >= birdType5) {
            
            value = 4;
        }
        
        else if (birdType5 > birdType1 && birdType5 > birdType2 && birdType5 > birdType3 && birdType5 > birdType4) {
            
            value = 5;
        }
        
        return value;
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
