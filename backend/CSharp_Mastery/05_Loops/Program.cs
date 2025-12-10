using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for loops

            //this code prints 5 times 'Hello!'
            //i=1: start value
            //i<=5: end value
            //i++: increment or i--: decrement

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Hello!");
            }

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }

            //i+=3: to increase i by 3 
            for (int i = 3; i <= 50; i += 3)
            {
                Console.WriteLine(i);
            }

            int finishValue;
            Console.Write("How many times you want to print 'Hi!': ");
            finishValue = int.Parse(Console.ReadLine());
            for (int i = 0; i <= finishValue; i++)
            {
                Console.WriteLine("Hi!");
            }
            #endregion

            Console.WriteLine();

            #region for loops with conditional statements
            for (int i = 0; i <= 50; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            int totalValue = 0;

            for (int i = 0; i <= 10; i++)
            {
                totalValue += i;
            }

            Console.Write("Total Value is: " + totalValue);

            #endregion

            Console.WriteLine();

            #region while loops
            int j = 1;

            while (j <= 10)
            {
                Console.WriteLine("While Loop!");
                j++;
            }

            int k = 1;
            while (k <= 10)
            {
                if (k % 3 == 0)
                {
                    Console.WriteLine(k);
                }
                k++;
            }

            int x = 1;
            int sum = 0;

            while (x <= 10)
            {
                sum += x;
                x++;
            }

            Console.WriteLine(sum);

            #endregion

            Console.WriteLine();

            #region example question
            //Write the code that finds the sum of the digits of a 3-digit number entered from the keyboard.

            int ones, tens, hundreds, number, totVal;

            Console.WriteLine("Enter a 3-digit number: ");
            number = int.Parse(Console.ReadLine());

            ones = number % 10;
            tens = (number % 100)/10;
            hundreds = number / 100;
            totVal = hundreds + tens + ones;

            Console.WriteLine(hundreds + "-" + tens + "-" + ones);
            Console.WriteLine(totVal);
            
            #endregion

            Console.Read();
        }
    }
}