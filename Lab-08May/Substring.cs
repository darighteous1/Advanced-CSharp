namespace Debugging_Substring
{
    using System;

    public class Substring_broken
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            //const char Search = 'р';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'p')
                {
                    hasMatch = true;

                    int substringLength = jump+1;

                    if (substringLength > text.Length-i)
                    {
                        string toPrint = text.Substring(i);
                        Console.WriteLine(toPrint);
                    }
                    else
                    {
                        string matchedString = text.Substring(i, substringLength);
                        Console.WriteLine(matchedString);
                    }
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
