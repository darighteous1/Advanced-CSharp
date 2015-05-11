using System;
using System.Collections.Generic;
using System.Linq;

class SubsetSums
{
    static void Main()
    {
        // read and save input data
        int sum = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();

        // convert input to int
        int[] numbers = new int[input.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        // calculate possible combinations
        int combinations = (int)Math.Pow(2, numbers.Length);

        // array to hold all the subsets (optional)
        //string[] subsets = new string[combinations]; 

        // iterate through combinations
        for (int i = 1; i < combinations; i++)
        {
            int currentSum = 0;
            string currentSubset = String.Empty;

            for (int j = 0; j < 32; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    currentSum += numbers[j];
                    currentSubset += numbers[j] + " ";
                }
            }

            // if you want to see all subsets uncomment this and line 25
            //subsets[i - 1] = currentSubset.Trim();
            //subsets.ToList().ForEach(set => Console.WriteLine(set));

            if (currentSum == sum)
            {
                string[] currentResult = currentSubset.Trim().Split();
                string output = String.Join(" + ", currentResult) + " = " + sum;
                Console.WriteLine(output);

                // and the hardcore one-liner
                // Console.WriteLine(String.Join(" + ", currentSubset.Trim().Split()) + " = " + sum);
                 
            }
        }

    }
}