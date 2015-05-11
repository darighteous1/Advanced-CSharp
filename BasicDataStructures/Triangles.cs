using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Methods
{
    class Triangles
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintUpperPart(n);

            PrintMiddleRow(n);
            
            Console.WriteLine();

            PrintBottomPart(n);
        }

        private static void PrintBottomPart(int n)
        {
            for (int i = n - 1; i >= 1; i--)
            {
                PrintBottomRow(i);
            }
        }

        private static void PrintBottomRow(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }

        private static void PrintMiddleRow(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }
        }

        private static void PrintUpperPart(int n)
        {
            for (int i = 1; i < n; i++)
            {
                PrintUpperRow(i);

            }
        }

        private static void PrintUpperRow(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
