using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basic array examples

            string[] colors = new string[4];

            colors[0] = "red";
            colors[1] = "yellow";
            colors[2] = "white";
            colors[3] = "blue";

            Console.WriteLine(colors[2]);

            int[] numbers = new int[10];
            numbers[0] = 60;
            numbers[1] = 33;
            numbers[2] = 896;
            numbers[3] = 50;
            numbers[4] = 790;
            numbers[7] = 123;

            Console.WriteLine(numbers[5]);
            Console.WriteLine(numbers[7]);

            string[] cities = { "Gazza", "Istanbul", "Vienna", "Paris" };
            Console.WriteLine(cities[0]);

            #endregion

            Console.WriteLine();

            #region Listing the elements in the array

            string[] colors2 = { "red", "blue", "turqouise", "white", "black", "yellow" };

            for (int i = 0; i < colors2.Length; i++)
            {
                Console.WriteLine(colors2[i]);
            }

            int[] numbers2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers2[j] % 3 == 0)
                {
                    Console.WriteLine(numbers2[j]);
                }
            }

            //finding the largest value in an array
            int[] myArray = { 50, 99, 652, 1, 66, 781, 57 };
            int maxNumber = myArray[0];

            for (int k = 1; k < myArray.Length; k++)
            {
                if (myArray[k] > maxNumber)
                {
                    maxNumber = myArray[k];
                }
            }

            Console.WriteLine("Largest value is: " + maxNumber);

            //printing the length of an array
            string[] persons = { "Me", "Erdogan", "Trump", "Putin" };
            Console.WriteLine(persons.Length);

            Console.WriteLine("--------------------------------------------------------------------------");

            int[] numbers3 = { 57, 66, 89, 1, 3, 0, 4, 88 };
            Array.Sort(numbers3);

            for (int l = 0; l < numbers3.Length; l++)
            {
                Console.WriteLine(numbers3[l]);
            }


            #endregion

            Console.WriteLine();

            #region Methods with arrays

            string[] customers = { "Ali Baba", "Cinderella", "Snow White", "Rapunzel" };
            int index = Array.IndexOf(customers, "Snow White");
            Console.WriteLine(index);

            int[] numbers4 = { 50, 66, 1, 568, 3, 785, 441 };
            Console.WriteLine("The largest value in the array is: " + numbers4.Max() + " " + "The smallest value in the array is: " + numbers4.Min());

            #endregion

            Console.WriteLine();

            #region Getting input from users to arrays

            string[] capitalCities = new string[5];

            for (int t = 0; t < capitalCities.Length; t++)
            {
                Console.Write($"Enter the {t + 1}. city: ");
                capitalCities[t] = Console.ReadLine();
            }

            Console.WriteLine("------------------------------------------------------------") ;
           
            for (int p = 0; p < capitalCities.Length; p++) { 
                Console.WriteLine(capitalCities[p]);
            }

            #endregion

            Console.ReadLine();
        }
    }
}
