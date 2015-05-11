using System;
using System.Linq;

class IncreasingSequence
{
    static void Main()
    {
        // read input from console and add it to an array
        string[] input = Console.ReadLine().Split();
        int[] numbers = Array.ConvertAll(input, n => int.Parse(n));

        // input.ToList().ForEach(x => Console.Write(x + " "));
        // iterate through the array and print entries

        int startIndex = 0;
        int longestSequence = 0;
        int startLongestSequence = 0;
        int endLongestSequence = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentIndex = i;
            int currentSequenceLength = currentIndex - startIndex + 1; // the +1 is to include the starting number

            Console.Write(numbers[i] + " ");

            // if the next entry is different, print a new line
            if (numbers[i] >= numbers[i + 1 < numbers.Length ? i + 1 : numbers.Length - 1])
            {
                Console.WriteLine();
                startIndex = i + 1;

                if (currentSequenceLength > longestSequence)
                {
                    longestSequence = currentSequenceLength;

                    // find the start and end index of the longest sequence
                    endLongestSequence = Array.IndexOf(numbers, numbers[i]);
                    startLongestSequence = endLongestSequence - currentSequenceLength +1;
                }
            }
        }

        // print the result to the console
        Console.Write("Longest: ");
        for (int i = startLongestSequence; i <= endLongestSequence; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}