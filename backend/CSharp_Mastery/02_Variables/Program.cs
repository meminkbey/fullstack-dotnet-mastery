using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String variables
            string customerName;
            string customerSurname;
            string customerEmail;
            string customerPhone;
            string customerCity, customerDistrict;

            customerName = "John";
            customerSurname = "Doe";
            customerPhone = "+90 500 400 30 20";
            customerCity = "New York";
            customerDistrict = "Brooklyn";
            customerEmail = "john@doe.com";

            Console.WriteLine("**** Customer Information ****");

            //Leave one blank line.
            Console.WriteLine();
            Console.WriteLine("Customer: " + customerName + " " + customerSurname);
            Console.WriteLine("Contact: " + customerPhone);
            Console.WriteLine("Email: " + customerEmail);
            Console.WriteLine("Address: " + customerCity + "/" + customerDistrict);
            Console.WriteLine();
            Console.WriteLine("**** Customer Information ****");
            Console.WriteLine();

            //int variables
            int hamburegerPrice = 10;
            int cokePrice = 2;
            int waterPrice = 1;
            int friesPrice = 3;
            int pizzaPrice = 8;
            int lemonadePrice = 2;

            Console.WriteLine("**** Restaurant Price List ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + "$" + hamburegerPrice);
            Console.WriteLine("-----Coke: " + "$" + cokePrice);
            Console.WriteLine("-----Water: " + "$" + waterPrice);
            Console.WriteLine("-----Fries: " + "$" + friesPrice);
            Console.WriteLine("-----Pizza: " + "$" + pizzaPrice);
            Console.WriteLine("-----Lemonade: " + "$" + lemonadePrice);
            Console.WriteLine();
            Console.WriteLine("**** Restaurant Price List ****");

            Console.WriteLine();

            int hamburgerCount = 3;
            int cokeCount = 3;
            int waterCount = 3;
            int friesCount = 1;
            int pizzaCount = 0;
            int lemonadeCount = 0;

            int totalHamburgerPrice = 0;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            totalHamburgerPrice = hamburgerCount * hamburegerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;

            Console.WriteLine("Hamburger Price: " + "$" + totalHamburgerPrice);
            Console.WriteLine("Coke Price: " + "$" + totalCokePrice);
            Console.WriteLine("Water Price: " + "$" + totalWaterPrice);
            Console.WriteLine("Fries Price: " + "$" + totalFriesPrice);
            Console.WriteLine("Pizza Price: " + "$" + totalPizzaPrice);
            Console.WriteLine("Lemonade Price: " + "$" + totalLemonadePrice);

            int totalPrice = totalCokePrice + totalWaterPrice + totalFriesPrice + totalHamburgerPrice + totalLemonadePrice + totalPizzaPrice;
            Console.WriteLine();
            Console.WriteLine("Total Price to Pay: " + "$" + totalPrice);


            Console.Read();

        }
    }
}
