using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LegoBlocks
{
    static void Main()
    {
        // read input number of rows and initialize the jagged arrays
        int n = int.Parse((Console.ReadLine()));
        int[][] firstArray = new int[n][];
        int[][] secondArray = new int[n][];

        // fill arrays with input from console
        FillArray(n, firstArray);
        FillArray(n, secondArray);

        // PrintArray(n, firstArray);
        // PrintArray(n, secondArray);

        // reverse second array
        ReverseArray(secondArray);

        // if arrays cannot form a matrix, print total number of cells and exit program
        if (!ArraysCanFormMatrix(firstArray, secondArray))
        {
            int totalCells = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                totalCells += (firstArray[i].Length + secondArray[i].Length);
            }
            Console.WriteLine("The total number of cells is: {0}", totalCells);
            return;
        }

        // initialize resulting matrix
        int matrixRows = firstArray.Length;
        int matrixCols = firstArray[0].Length + secondArray[0].Length;
        int[,] matrix = new int[matrixRows, matrixCols];

        // fill first array in the matrix
        for (int i = 0; i < matrixRows; i++)
        {
            for (int j = 0; j < firstArray[i].Length; j++)
            {
                matrix[i, j] = firstArray[i][j];
            }
        }

        // then fill the entries from second array at the empty matrix cells
        for (int i = 0; i < matrixRows; i++)
        {
            for (int j = matrixCols - (secondArray[i].Length), k = 0; j < matrixCols; j++, k++)
            {
                matrix[i, j] = secondArray[i][k];
            }
        }

        // print matrix;
        for (int i = 0; i < matrixRows; i++)
        {
            string[] currentRow = new string[matrixCols];
            for (int j = 0; j < matrixCols; j++)
            {
                if (j == 0)
                {
                    Console.Write("[");
                }
                currentRow[j] = matrix[i, j].ToString();

            }
            Console.WriteLine(String.Join(", ", currentRow) +"]");
        }

    }

    public static bool ArraysCanFormMatrix(int[][] firstArray, int[][] secondArray)
    {
        int lengthToMatch = firstArray[0].Length + secondArray[0].Length;
        for (int i = 1; i < firstArray.Length; i++)
        {
            if ((firstArray[i].Length + secondArray[i].Length) != lengthToMatch)
            {
                return false;
            }
        }
        return true;
    }

    private static void ReverseArray(int[][] arrayToReverse)
    {
        for (int i = 0; i < arrayToReverse.Length; i++)
        {
            arrayToReverse[i] = arrayToReverse[i].Reverse().ToArray();
        }
    }

    private static void FillArray(int n, int[][] arrayToFill)
    {
        for (int i = 0; i < n; i++)
        {
            string[] strInput = Console.ReadLine().Trim().Split();
            int[] input = new int[strInput.Length];
            for (int j = 0; j < input.Length; j++)
            {
                input[j] = int.Parse(strInput[j]);
            }

            arrayToFill[i] = input;
        }
        //return arrayToFill;
    }

    private static void PrintArray(int n, int[][] arrayToPrint)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < arrayToPrint[i].Length; j++)
            {
                Console.Write(arrayToPrint[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

}
