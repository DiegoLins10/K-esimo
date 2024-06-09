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
     * Complete the 'findMissingInteger' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY arr
     *  2. LONG_INTEGER k
     */

    public static long findMissingInteger(List<int> arr, long k)
    {
        // Filter and sort the list
        var positiveNumbers = arr.Where(x => x > 0).Distinct().OrderBy(x => x);

        long current = 1;

        // Iterate through the positive numbers
        foreach (int number in positiveNumbers)
        {
            // If the current number is different from the current number in the list
            if (current != number)
            {
                // If the count of missing integers reaches K, return the 'current'
                if (--k == 0)
                    return current;
            }
            // Move to the next integer
            current = number + 1;
        }

        // If the Kth missing integer is not found yet, return the next available integer
        return current + k - 1;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = new List<int>();

        for (int i = 0; i < arrCount; i++)
        {
            int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
            arr.Add(arrItem);
        }

        long k = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.findMissingInteger(arr, k);

        Console.WriteLine(result);


    }
}
