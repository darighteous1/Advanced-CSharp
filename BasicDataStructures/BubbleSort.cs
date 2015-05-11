using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

class BubbleSort
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int[] intArray = new int[input.Length];


        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = int.Parse(input[i]);
        }

        for (int j = 0; j < intArray.Length; j++)
        {
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                if (intArray[i] > intArray[i + 1])
                {
                    int temp = intArray[i + 1];
                    intArray[i + 1] = intArray[i];
                    intArray[i] = temp;
                }
            }
        }

        string output = "[" + String.Join(",", intArray) + "]";
        Console.WriteLine(output);
    }
}