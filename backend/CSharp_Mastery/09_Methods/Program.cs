using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region void methods

            //void methods (non returning methods)
            void CustomerList()
            {
                Console.WriteLine("John Doe");
                Console.WriteLine("Rick");
                Console.WriteLine("Morty");
                Console.WriteLine("Bart Simpson");
            }

            //this is how to call a function
            CustomerList();

            void Sum()
            {
                int x = 1;
                int y = 2;
                int z = x + y;

                Console.WriteLine(z);
            }


            Sum();

            #endregion

            Console.WriteLine();

            #region void methods with string parameters

            void Hello(string name)
            {
                Console.WriteLine($"Hello {name}!");
            }

            Hello("John Doe");


            void CustomerCard(string name, string surName)
            {
                Console.WriteLine($"Customer: {name} {surName}");
            }

            CustomerCard("John", "Doe");

            #endregion

            Console.WriteLine();

            #region void methods with int parameters

            void Add(int number1, int number2, int number3)
            {
                int result = number1 + number2 + number3;
                Console.WriteLine(result);
            }

            Add(50, 65, 788);

            #endregion

            Console.WriteLine();

            #region methods that return a value

            string StudentCard()
            {
                string name = "Bart";
                string surName = "Simpson";

                return name + " " + surName;
            }

            Console.WriteLine(StudentCard());

            #endregion

            Console.WriteLine();

            #region methods with string parameters that return a value

            string CountryCard(string countryName, string capital, string flagColor)
            {
                string cardInfo = "Country: " + countryName + " - Capital: " + capital + " - Flag color: " + flagColor;
                return cardInfo;
            }

            string a, b, c;

            Console.Write("Enter the Country: ");
            a = Console.ReadLine();

            Console.Write("Enter the Capital: ");
            b = Console.ReadLine();

            Console.Write("Enter the Flag color: ");
            c = Console.ReadLine();

            Console.WriteLine(CountryCard(a, b, c));

            #endregion

            Console.WriteLine();

            #region methods with int parameters that return a value
            
            int Addition (int number1, int number2, int number3)
            {
                int result = number1 + number2 + number3;
                return result;
            }

            Console.WriteLine(Addition(20, 55, 43));

            #endregion

            Console.WriteLine() ;

            #region sample exam calculator

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int avg = (exam1 + exam2 + exam3) / 3;

                if (avg < 50)
                {
                    return student + " failed!";
                }
                else
                {
                    return student + " passed!";
                }
            }

            Console.WriteLine(ExamResult("Christina", 50, 90, 84));
            Console.WriteLine(ExamResult("Albert", 50, 30, 17));

            #endregion

            Console.Read();
        }
    }
}
