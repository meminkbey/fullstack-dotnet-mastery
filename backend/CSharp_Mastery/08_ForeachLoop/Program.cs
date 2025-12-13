using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreach loop

            string[] cities = { "Gazza", "Istanbul", "Vienna", "Milano", "Ankara" };
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            //list the even numbers in the array
            int[] numbers = { 506, 8, 160, 10839, 411, 2209, 4, 78 };

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }

            //sum the numbers in the array
            int[] numbers2 = { 32, 6, 5, 71, 88, 932 };
            int total = 0;

            foreach (int i in numbers2)
            {
                total += i;
            }

            Console.WriteLine(total);

            #endregion

            Console.WriteLine();

            #region using List with loops

            //this is how to create a list
            List<int> listOfNumbers = new List<int>()
            {
                1,2,6,7,5,9
            };

            foreach (int j in listOfNumbers)
            {
                Console.WriteLine(j); 
            }

            //extract characters on a string
            string word = "Hello World!";

            foreach(char c in word)
            {
                Console.WriteLine(c); 
            }
            #endregion

            Console.WriteLine();

            #region Sample exam records application

            Console.WriteLine("**** C# Exam Records App ****");
            Console.WriteLine();

            Console.Write("How many students are in the class: ");
            int studentCount = int.Parse(Console.ReadLine());

            string[] studentName = new string[studentCount];
            double[] studentsExamAvg = new double[studentCount];

            for (int k = 0; k < studentCount; k++)
            {
                Console.Write($"Name of the {k+1}. student: ");
                studentName[k] = Console.ReadLine();

                double totalExam = 0;
                for (int l = 0; l < 3; l++)
                {
                    Console.Write($"{studentName[k]} 's {l + 1} exam: ");
                    totalExam += double.Parse(Console.ReadLine());
                }

                studentsExamAvg[k] = totalExam/3;
                Console.WriteLine();

            }
            Console.WriteLine();

            for (int k = 0;k < studentCount; k++)
            {
                Console.WriteLine($"{studentName[k]} 's average result is: {studentsExamAvg[k]}");

                if (studentsExamAvg[k] < 50)
                {
                    Console.WriteLine($"{studentName[k]} failed the course.");
                }
                else
                {
                    Console.WriteLine($"{studentName[k]} passed the course.");
                }
            }

            #endregion

            Console.Read();
        }
    }
}
