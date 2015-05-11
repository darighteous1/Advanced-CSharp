using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
         
        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsLargerThanNeighbours(numbers, i))
            {
                
                Console.WriteLine(i);
                return;
            }
        }
        Console.WriteLine(-1);
    }

    static bool IsLargerThanNeighbours(int[] numbers, int index)
    {
        if ((index == 0) || (index == numbers.Length - 1))
        {
            return index == 0 ? numbers[index] > numbers[index + 1] : (numbers[index] > numbers[index - 1]);
        }
        return (numbers[index] > numbers[index + 1]) && (numbers[index] > numbers[index - 1]);
    }
}