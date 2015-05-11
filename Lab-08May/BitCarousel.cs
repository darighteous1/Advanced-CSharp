namespace Debugging_BitCarousel
{
    using System;

    class BitCarousel
    {
        static void Main()
        {
            //changed data type to integer 
            int number = int.Parse(Console.ReadLine());
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string direction = Console.ReadLine();

                if (direction == "right")
                {
                    int rightMostBit = number & 1;
                    number >>= 1;
                    number |= rightMostBit << 5; //changed value to 5
                }
                else if (direction == "left")
                {
                    int leftMostBit = (number >> 5) & 1; //changed value to 5
                    number <<= 1;
                    number &= ~(1<<6); // clear bit at index 6
                    number |= leftMostBit;
                }
            }

            Console.WriteLine(number);
        }
    }
}
