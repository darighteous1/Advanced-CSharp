using System;
using System.Collections.Generic;
using System.Linq;

class ArraySort
{
    static void Main()
    {
        // read input and convert numbers to int
        string[] input = Console.ReadLine().Split();
        int[] numbers = new int[input.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        // sort array and print the result with LINQ
        List<int> result = numbers.ToList();
        result.Sort();
        result.ForEach(n => Console.Write(n + " "));
    }
}