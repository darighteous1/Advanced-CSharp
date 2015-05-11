using System;

class FindSequel
{
    static void Main()
    {
        // read input from console and add it to an array
        string[] input = Console.ReadLine().Split();

        // iterate through the array and print entries
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write(input[i] + " ");

            /* if the next entry is different, print a new line
             * ternary operator to determine if we reached the end of the array */
            if (input[i] != input[i + 1 < input.Length ? i + 1 : input.Length - 1]) 
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }
}
