using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class JoinLists
{
    static void Main()
    {
        // create two lists to hold the input data
        List<string> firstList = new List<string>(Console.ReadLine().Split());
        List<string> secondList = new List<string>(Console.ReadLine().Split());

        // create a list that will hold the result
        List<string> result = new List<string>();
        
        // iterate over the two lists and add entries to result if they are not present
        for (int i = 0; i < firstList.Count; i++)
        {
            if (!result.Contains(firstList[i]))
            {
                result.Add(firstList[i]);
            }
        }

        for (int i = 0; i < secondList.Count; i++)
        {
            if (!result.Contains(secondList[i]))
            {
                result.Add(secondList[i]);
            }
        }

        // sort the resulting list with LINQ
        result.Sort();

        foreach (var num in result)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
