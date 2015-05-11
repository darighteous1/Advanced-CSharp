using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Calculations
{
    static void Main()
    {
        //to check methods with double or decimal, just comment out row 14 and uncomment row 15 or 16

        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        //double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
        //decimal[] numbers = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
        Console.WriteLine(GetMax(numbers));
        Console.WriteLine(GetMin(numbers));
        Console.WriteLine(GetSum(numbers));
        Console.WriteLine("{0:F3}", GetAverage(numbers));
        Console.WriteLine(GetProduct(numbers));
    }

    static int GetMax(int[] numbers)
    {
        int max = Int32.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    static int GetMin(int[] numbers)
    {
        int min = Int32.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }

    static int GetSum(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    static double GetAverage(int[] numbers)
    {
        return (double)GetSum(numbers) / numbers.Length;
    }

    static long GetProduct(int[] numbers)
    {
        long product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }

    // overload for DOUBLE
    static double GetMax(double[] numbers)
    {
        double max = Double.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    static double GetMin(double[] numbers)
    {
        double min = Double.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }

    static double GetSum(double[] numbers)
    {
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    static double GetAverage(double[] numbers)
    {
        return GetSum(numbers) / numbers.Length;
    }

    static double GetProduct(double[] numbers)
    {
        double product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }

    // overload for DECIMAL 
    static decimal GetMax(decimal[] numbers)
    {
        decimal max = Decimal.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    static decimal GetMin(decimal[] numbers)
    {
        decimal min = Decimal.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }

    static decimal GetSum(decimal[] numbers)
    {
        decimal sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    static decimal GetAverage(decimal[] numbers)
    {
        return GetSum(numbers) / numbers.Length;
    }

    static decimal GetProduct(decimal[] numbers)
    {
        decimal product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
}