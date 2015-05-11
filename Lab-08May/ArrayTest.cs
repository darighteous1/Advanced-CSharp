namespace Arrays
{
    using System;
    using System.Linq;

    public class ArraysMain
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop")) // changed to 'stop'
            {
                //string line = Console.ReadLine().Trim(); -> unnecessary
                int[] args = new int[2];

                if (command.Contains("add") || //changed to contains instead of equals
                    command.Contains("subtract") ||
                    command.Contains("multiply"))
                    {
                        string[] stringParams = command.Split(ArgumentsDelimiter); // changed to read arguments from command
                        // changed to stringParams 1 and 2
                        args[0] = int.Parse(stringParams[1]);
                        args[1] = int.Parse(stringParams[2]);

                        PerformAction(array, stringParams[0], args); // changed to stringParams[0]
                    }
                else
                {
                    PerformAction(array, command, args);
                }

                PrintArray(array);

                command = Console.ReadLine();
            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
            //long[] array = arr.Clone() as long[]; // this creates new object and the method works with it, thus the initial array is intact
            int pos = args[0] - 1; 
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    arr[pos] *= value;
                    break;
                case "add":
                    arr[pos] += value;
                    break;
                case "subtract":
                    arr[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    ArrayShiftRight(arr);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            var tempList = array.ToList();
            long valueToShift = tempList[array.Length-1];
            tempList.RemoveAt(array.Length-1);
            tempList.Insert(0, valueToShift);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = tempList[i];
            }
        }

        private static void ArrayShiftLeft(long[] array)
        {
            //to test -> iterate through array, save value to shift and then replace with previous index (i.e. fix author's solution)
            var tempList = array.ToList();
            long valueToShift = tempList[0];
            tempList.RemoveAt(0);
            tempList.Add(valueToShift);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = tempList[i];
            }
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
