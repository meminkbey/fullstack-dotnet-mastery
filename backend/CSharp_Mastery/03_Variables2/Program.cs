using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Variables2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //each region can be commented out for cleaner output!
            #region double
            double applePrice = 2.80;
            double orangePrice = 1.70;
            double strawberryPrice = 2.40;
            double potatoPrice = 0.80;
            double tomatoPrice = 1.10;

            Console.WriteLine("---- Apple: " + "$" + applePrice);
            Console.WriteLine("---- Orange: " + "$" + orangePrice);
            Console.WriteLine("---- Strawberry: " + "$" + strawberryPrice);
            Console.WriteLine("---- Potato: " + "$" + potatoPrice);
            Console.WriteLine("---- Tomato: " + "$" + tomatoPrice);

            double appleWeight = 3.40;
            double orangeWeight = 2.10;
            double strawberryWeight = 1.30;
            double potatoWeight = 5.25;
            double tomatoWeight = 3.60;

            double appleTotalPrice = applePrice * appleWeight;
            double orangeTotalPrice = orangePrice * orangeWeight;
            double strawberryTotalPrice = strawberryPrice * strawberryWeight;
            double potatoTotalPrice = potatoPrice * potatoWeight;
            double tomatoTotalPrice = tomatoPrice * tomatoWeight;

            double grandTotal = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            Console.WriteLine();

            Console.WriteLine("Item purchased: Apple | Unit Price: $" + applePrice + " | Weight: " + appleWeight + "kg" +" | Price: $" + appleTotalPrice);
            Console.WriteLine("Item purchased: Orange | Unit Price: $" + orangePrice + " | Weight: " + orangeWeight + "kg" +" | Price: $" + orangeTotalPrice);
            Console.WriteLine("Item purchased: Strawberry | Unit Price: $" + strawberryPrice + " | Weight: " + strawberryWeight + "kg" +" | Price: $" + strawberryTotalPrice);
            Console.WriteLine("Item purchased: Potato | Unit Price: $" +  potatoPrice+ " | Weight: " + potatoWeight + "kg" +" | Price: $" + potatoTotalPrice);
            Console.WriteLine("Item purchased: Tomato | Unit Price: $" + tomatoPrice + " | Weight: " + tomatoWeight + "kg" +" | Price: $" + tomatoTotalPrice);
            Console.WriteLine("Grand Total: " + "$" + grandTotal);
            #endregion

            Console.WriteLine();

            #region char
            char symbol;
            symbol = 'a';

            Console.WriteLine(symbol);

            #endregion

            Console.WriteLine();

            #region user input

            String passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.WriteLine("**** CSharp Airlines ****");
            Console.WriteLine();

            Console.Write("Passenger Name: ");
            //Console.readline gets an input from user
            passengerName = Console.ReadLine();

            Console.Write("Passenger Surname: ");
            passengerSurname = Console.ReadLine();

            Console.Write("Passenger District: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Passenger City: ");
            passengerCity = Console.ReadLine();

            Console.Write("Passenger Age: ");
            passengerAge = Console.ReadLine();

            Console.Write("Passenger Identity Number: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Passenger: " + passengerName + " " + passengerSurname +  " " + "Passenger Identity Number: " + passengerIdentityNumber + " " + "Age: " + passengerAge + " " + passengerCity + "/" + passengerDistrict);

            #endregion

            #region Reading integers from user and parsing

            Console.WriteLine("**** CSharp Shop ****");

            int shoesPrice, tvPrice, chairPrice, computerPrice, shoesCount, tvCount, chairCount, computerCount;
            
            shoesPrice = 40;
            tvPrice = 200;
            chairPrice = 25;
            computerPrice = 1000;

            //int.parse() converts String type to int
            Console.Write("Amount of Shoes: ");
            shoesCount = int.Parse(Console.ReadLine());

            Console.Write("Amount of TV: ");
            tvCount = int.Parse(Console.ReadLine());

            Console.Write("Amount of Chair: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Amount of Computer: ");
            computerCount = int.Parse(Console.ReadLine());

            int totalPrice = shoesCount * shoesPrice + tvPrice * tvCount + chairPrice * chairCount + computerPrice * computerCount;

            Console.WriteLine("Total Price: " + "$" + totalPrice);

            #endregion

            Console.WriteLine();

            #region Reading floating-point numbers from user
            double exam1, exam2, exam3;

            //double.parse() converts String to double

            Console.WriteLine("First Exam Point (0-100): ");
            exam1 = double.Parse(Console.ReadLine());

            Console.WriteLine("First Exam Point (0-100): ");
            exam2 = double.Parse(Console.ReadLine());

            Console.WriteLine("First Exam Point (0-100): ");
            exam3 = double.Parse(Console.ReadLine());

            double result = (exam1 + exam2 + exam3)/3;
            Console.WriteLine("Average Point: " + result);

            #endregion

            Console.WriteLine();

            #region Reading characters from user

            char gender;

            //char gets only one character from the user. If the input is more than one character the program will throw an error!

            Console.WriteLine("Your gender: ") ;
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Your gender is: " + gender);



            #endregion



            Console.Read();
        }
    }
}
