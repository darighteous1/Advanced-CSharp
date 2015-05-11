using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main(string[] args)
    {
        // For an array of your choice uncomment line 9 and comment out line 10
        // int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i) ? "True" : "False");
        }
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