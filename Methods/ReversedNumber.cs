using System;

class ReversedNumber
{
    static void Main(string[] args)
    {
        double number = double.Parse(Console.ReadLine());

        ReverseNumber(number);

    }

    private static void ReverseNumber(double number)
    {
        string reversed = number.ToString();
        for (int i = reversed.Length - 1; i >= 0; i--)
        {
            Console.Write(reversed[i]);
        }
    }
}