using System;
using System.Collections.Generic;

public class BePositive //renamed class
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());
        char[] splitChars = { ' ' };

        List<string> output = new List<string>();

        for (int i = 0; i < countSequences; i++)
        {
            // added StringSplitOptions.RemoveEmptyEntries to avoid wrong format exception
            string[] input = Console.ReadLine().Trim().Split(splitChars, StringSplitOptions.RemoveEmptyEntries);
            var numbers = new List<int>();

            for (int j = 0; j < input.Length; j++)
            {
                // FIXED: wrong input reading - changed input[i] to input [j]
                // optimized code - removed unnecesary check with RemoveEmptyEntries at line 15
                int num = int.Parse(input[j]);
                numbers.Add(num);
            }

            bool found = false;

            // in order to have correct output, create empty string and add numbers to print to it
            // at the end of the current interation add the string to results list
            string toPrint = String.Empty;

            for (int j = 0; j < numbers.Count; j++)
            {
                int currentNum = numbers[j];
                if (currentNum >= 0)
                {
                    //if (found)
                    //{
                    //    Console.Write(" ");
                    //}
                    //Console.Write(currentNum + " ");
                    toPrint += (currentNum + " ");
                    found = true;
                }
                else
                {
                    // add check if next number is within bounds of list
                    if (j + 1 >= numbers.Count)
                    {
                        j++;
                    }
                    else
                    {
                        currentNum += numbers[j + 1];

                        if (currentNum >= 0)
                        {
                            toPrint += (currentNum + " ");

                            //Console.Write(currentNum + " ");

                            found = true;
                        }
                    }
                    j++; // if current number is negative, we need to skip next number regardless of its sign
                }
            }
            // changed logic to add output results to list instead of runtime printing
            // to avoid mixing input and output
            if (!found)
            {
                output.Add("(empty)");
                // Console.WriteLine("(empty)");
            }
            else
            {
                output.Add(toPrint.TrimEnd());
            }
        }

        // print results
        foreach (var result in output)
        {
            Console.WriteLine(result);
        }
    }
}
