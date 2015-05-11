using System;
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

        // sort array with selection sort

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int? currentMin = null;
            int indexToSwap = 0; /* maybe there's a better way to declare this, 
            * but in general indexToSwap could be 0 only if the 0 and first element are both the smallest 
            * e.g. 1 1 5 4 2 (will swap 1 and 1) */

            // find the smallest number between entries, sorted and current entry excluded
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (currentMin == null || numbers[j] < currentMin)
                {
                    currentMin = numbers[j];
                    indexToSwap = j;
                }
            }

            // if current entry is bigger than currentMin -> swap them
            if (numbers[i] > currentMin)
            {
                int swapVar = numbers[indexToSwap];
                numbers[indexToSwap] = numbers[i];
                numbers[i] = swapVar;
            }
        }

        // print the result on the console
        numbers.ToList().ForEach(n => Console.Write(n + " "));
    }
}