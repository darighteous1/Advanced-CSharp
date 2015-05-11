using System;
using System.Collections.Generic;
using System.Linq;

class CategorizeNumbers
{
    static void Main()
    {
        // read input from the console
        string[] input = Console.ReadLine().Split();
        
        // create a list for round numbers (integers) and a list for real numbers (floats)
        List<float> roundNumbers = new List<float>();
        List<float> floats = new List<float>();

        for (int i = 0; i < input.Length; i++)
        {
            if (float.Parse(input[i]) % 1 == 0)
            {
                roundNumbers.Add(float.Parse(input[i]));
            }
            else
            {
                floats.Add(float.Parse(input[i]));
            }
        }

        // print the result on the console
        Console.WriteLine();
        roundNumbers.ForEach(x => Console.WriteLine("[{0}, {1}, {2}, {3}]", roundNumbers.Min(), roundNumbers.Max(), roundNumbers.Sum(), roundNumbers.Average()));
        floats.ForEach(x => Console.WriteLine("[{0}, {1}, {2}, {3}]", floats.Min(), floats.Max(), floats.Sum(), floats.Average()));
    }
}