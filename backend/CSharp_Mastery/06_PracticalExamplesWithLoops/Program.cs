using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _06_PracticalExamplesWithLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region example 1:

            //Write a program that prints 10 stars, each on a new line.
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("*");
            }
            #endregion

            Console.WriteLine("-----------------------------------");

            #region example 2:

            //Print 10 stars side by side (horizontally).
            for (int m = 1; m <= 10; m++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------------");

            #region example 3:

            //Print 10 rows, each containing 10 stars.

            for (int t = 1; t <= 10; t++)
            {
                Console.WriteLine("**********");
            }

            #endregion

            Console.WriteLine();

            #endregion

            Console.WriteLine("-----------------------------------");

            #region example 3:

            //Create a right triangle pattern of stars with a height of 5 and base of 5.
            for (int j = 1; j <= 5; j++)
            {
                for (int k = 1; k <= j; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            Console.WriteLine("-----------------------------------");

            #region example 4:

            //Now make both an inverted triangle with stars, each having a height of 5 and a width of 5.
            for (int p = 5; p >= 1; p--)
            {
                for (int l = 1; l <= p; l++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            #endregion

            Console.WriteLine("-----------------------------------");

            #region example 5:

            //Create a pyramide shape from stars. (height=5)
            int n = 5;
            for (int f = 1; f <= n; f++)
            {
                //spaces
                for (int g = 1; g <= n - f; g++)
                {
                    Console.Write(" ");
                }

                //stars
                for (int h = 0; h < 2 * f - 1; h++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion

            Console.WriteLine("-----------------------------------");

            #region example 6:
            //Create an inverted pyramide shape from stars. (height=5)
            int v = 5;
            for (int p = v; p >= 1; p--)
            {
                //spaces
                for (int h = v - p; h > 0; h--)
                {
                    Console.Write(" ");
                }

                //stars
                for (int m = 1; m <= 2 * p - 1; m++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            #endregion
        }
    }
}
