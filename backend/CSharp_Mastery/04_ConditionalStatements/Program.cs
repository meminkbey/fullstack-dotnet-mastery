using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if-else statements
            Console.Write("Enter the Password: ");
            string password;
            password = Console.ReadLine();

            if (password == "abcd")
            {
                Console.WriteLine("Password Correct!");
            }
            else
            {
                Console.WriteLine("Password Incorrect!");
            }

            string capital, country;

            Console.Write("Enter the country: ");
            country = Console.ReadLine();

            Console.Write("Enter the capital: ");
            capital = Console.ReadLine();

            //'&' stands for 'and'
            if (country == "usa" & capital == "washington")
            {
                Console.WriteLine("Correct Info!");
            }
            else
            {
                Console.WriteLine("Incorect Info!");
            }

            int number;

            Console.Write("Enter the number: ");
            number = int.Parse(Console.ReadLine());

            if (number == 5)
            {
                Console.WriteLine("The number is true!");
            }
            else
            {
                Console.WriteLine("The number is false");
            }

            int exam1, exam2, exam3, average;
            string result = "Error!";

            Console.Write("First exam: ");
            exam1 = int.Parse(Console.ReadLine());

            Console.Write("First exam: ");
            exam2 = int.Parse(Console.ReadLine());

            Console.Write("First exam: ");
            exam3 = int.Parse(Console.ReadLine());

            average = (exam1 + exam2 + exam3) / 3;

            if (average > 0 & average <= 50)
            {
                Console.WriteLine("Results are bad!");
            }
            if (average > 50 & average <= 70)
            {
                Console.WriteLine("Results are average!");
            }
            if (average > 84)
            {
                Console.WriteLine("Results are very good!");
            }

            string city;
            Console.Write("Enter the city: ");
            city = Console.ReadLine();

            //'|' stands for 'or'
            if (city == "Istanbul" | city == "New York" | city == "Vienna")
            {
                Console.WriteLine("City is available!");
            }
            else
            {
                Console.WriteLine("City is not available!");
            }

            string username;
            Console.Write("Enter the username: ");
            username = Console.ReadLine();

            if (username != "admin")
            {
                Console.WriteLine("Wrong username!");
            }
            else
            {
                Console.WriteLine("Welcome " + username + "!");
            }
            #endregion

            Console.WriteLine();

            #region mod operation

            Console.Write("Enter the number: ");
            int number1 = int.Parse(Console.ReadLine());

            //'%' means mod
            if (number % 2 == 0)
            {
                Console.WriteLine("It's even!");
            }
            else
            {
                Console.WriteLine("It's odd!");
            }

            #endregion

            Console.WriteLine();

            #region Simple Restaurant Menu project
            string menuItem;

            Console.WriteLine("**** C# Restaurant ****");
            Console.WriteLine("---------------");
            Console.WriteLine("1-Main Course");
            Console.WriteLine("2-Drinks");
            Console.WriteLine("3-Deserts");
            Console.WriteLine("---------------");

            Console.Write("Enter the Menu number: ");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine("---------------");
                Console.WriteLine("1-Pizza");
                Console.WriteLine("2-Döner Kebap");
                Console.WriteLine("3-Pasta");
                Console.WriteLine("---------------");
            }

            if (menuItem == "2")
            {
                Console.WriteLine("---------------");
                Console.WriteLine("1-Coke");
                Console.WriteLine("2-Ice Tea");
                Console.WriteLine("3-Lemonade");
                Console.WriteLine("---------------");
            }

            if (menuItem == "3")
            {
                Console.WriteLine("---------------");
                Console.WriteLine("1-Spungle");
                Console.WriteLine("2-Pancakes");
                Console.WriteLine("3-Choclate");
                Console.WriteLine("---------------");
            }

            #endregion

            Console.WriteLine();

            #region switch-case
            int monthNumber;

            Console.WriteLine("Enter the number of the month: ");
            monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 1: Console.WriteLine("January"); break;
                case 2: Console.WriteLine("February"); break;
                case 3: Console.WriteLine("March"); break;
                case 4: Console.WriteLine("April"); break;
                case 5: Console.WriteLine("May"); break;
                case 6: Console.WriteLine("Juny"); break;
                case 7: Console.WriteLine("July"); break;
                case 8: Console.WriteLine("August"); break;
                case 9: Console.WriteLine("September"); break;
                case 10: Console.WriteLine("October"); break;
                case 11: Console.WriteLine("November"); break;
                case 12: Console.WriteLine("December"); break;
                default: Console.WriteLine("Only numbers between 1 and 12!"); break;
            }


            #endregion

            Console.WriteLine();

            #region switch-case calculator

            int num1, num2, res;
            char symb;

            Console.Write("1. number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("2. number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the operation (*,/,-,+): ");
            symb = char.Parse(Console.ReadLine());

            switch (symb)
            {
                case '+':
                    res = num1 + num2;
                    Console.WriteLine("Addition= " + res);
                    break;

                case '-':
                    res = num1 - num2;
                    Console.WriteLine("Subtraction= " + res);
                    break;

                case '*':
                    res = num1 * num2;
                    Console.WriteLine("Multiplication= " + res);
                    break;

                case '/':
                    res = num1 / num2;
                    Console.WriteLine("Division= " + res);
                    break;

                default:
                    Console.WriteLine("Only /,*,-,+ operations are allowed!");
                    break;
            }



            #endregion

            Console.Read();
        }
    }
}
