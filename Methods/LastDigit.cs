using System;

class LastDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(LastDigitAsWord(number));
        Console.WriteLine(LastDig(number));
    }

    static string LastDigitAsWord(int num)
    {
        // version 1: switch-case
        int lastDigit = num % 10;
        string result = String.Empty;
        switch (lastDigit)
        {
            case 0:
                result = "zero";
                break;
            case 1:
                result = "one";
                break;
            case 2:
                result = "two";
                break;
            case 3:
                result = "three";
                break;
            case 4:
                result = "four";
                break;
            case 5:
                result = "five";
                break;
            case 6:
                result = "six";
                break;
            case 7:
                result = "seven";
                break;
            case 8:
                result = "eight";
                break;
            case 9:
                result = "nine";
                break;
        }
        return result;
    }

    static string LastDig (int num)
    {
        //version 2: array
        int lastDigit = num % 10;
        string result = String.Empty;
        string[] digits = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        result = digits[lastDigit];
        return result;
    }
}