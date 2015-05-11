using System;
//using System.Collections.Generic;
using System.Linq;

namespace _07.GenericArraySort
{
    class ArraySort
    {
        static void Main(string[] args)
        {
            // if you want to print an array, you can use PrintArray(array_name);

            // if you don't want to enter your own data, comment this out from here
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double[] doubles = Console.ReadLine().Split().Select(double.Parse).ToArray();
            DateTime[] dates = Console.ReadLine().Split().Select(DateTime.Parse).ToArray();
            string[] strings = Console.ReadLine().Split();

            BubbleSort<int>(integers);
            BubbleSort<string>(strings);
            BubbleSort<double>(doubles);
            BubbleSort<DateTime>(dates);

            // to here

            //and uncomment this from here
            
            //int[] ints = { 3, 1, 12432, -213 };
            //double[] realNums = { 1231.123, 5.432, 12.00003, -1 };
            //string[] str = { "fa", "bs", "dsac", "asjdkgad", "ba" };
            //DateTime[] date = { new DateTime(2012, 05, 01), new DateTime(2015, 02, 12), new DateTime(1900, 01, 30) };
            
            //BubbleSort<double>(realNums);
            //BubbleSort<int>(ints);
            //BubbleSort<string>(str);
            //BubbleSort<DateTime>(date);
            
            // to here
            Console.WriteLine();
        }

        private static void BubbleSort<T>(T[] arr) where T : IComparable
        {
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i].CompareTo(arr[i + 1]) > 0)
                    {
                        T temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }

        static void PrintArray<T>(T[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
