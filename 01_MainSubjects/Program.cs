using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            #region Writing to Console Commands
            //Console.WriteLine("Hello World!");
            //Console.Write("Greetings From C# Universe");

            //Console.WriteLine("***** Food Categories *****");
            //Console.WriteLine();
            //Console.WriteLine("1. Soups");
            //Console.WriteLine("2. Main Foods");
            //Console.WriteLine("3. Cold Starters");
            //Console.WriteLine("4. Salads");
            //Console.WriteLine("5. Desserts");
            //Console.WriteLine("6. Drinks");
            //Console.WriteLine();
            //Console.WriteLine("***** Food Categories *****");
            #endregion

            #region String Variables

            // string
            // variable_type variable_name;

            // string name;
            // name = "John";
            // Console.WriteLine(name);

            string customerName = "Femke";
            string customerLastName = "Bol";
            string customerPhone = "1234567890";
            string customerEmail = "femke@gmail.com";
            string customerDistrict = "Noord-Holland";
            string customerCity = "Amsterdam";

            Console.WriteLine("***** Reservation Card *****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Customer - 1 Informations");
            Console.WriteLine("Name: " + customerName);
            Console.WriteLine("Last Name: " + customerLastName);
            Console.WriteLine("Phone: " + customerPhone);
            Console.WriteLine("Email: " + customerEmail);
            Console.WriteLine("District: " + customerDistrict);
            Console.WriteLine("City: " + customerCity);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------");

            customerName = "Ayşegül";
            //Console.WriteLine("Name: " + customerName); // Ayşegül
            customerLastName = "Kaya";
            customerPhone = "0987654321";
            customerEmail = "aysegul@gmail.com";
            customerDistrict = "Beylikdüzü";
            customerCity = "İstanbul";

            Console.WriteLine("Customer - 2 Informations");
            Console.WriteLine("Name: " + customerName);
            Console.WriteLine("Last Name: " + customerLastName);
            Console.WriteLine("Phone: " + customerPhone);
            Console.WriteLine("Email: " + customerEmail);
            Console.WriteLine("District: " + customerDistrict);
            Console.WriteLine("City: " + customerCity);

            Console.WriteLine();




            #endregion

            #region Integer Variables

            // int
            //int myNum = 90;
            //Console.WriteLine("My Number: " + myNum);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int frenchFriesPrice = 50;
            int pizzaPrice = 200;
            int lemonadePrice = 25;

            Console.WriteLine("***** Restaurant Menu Prices *****");
            Console.WriteLine();
            Console.WriteLine("Hamburger: " + hamburgerPrice + " ₺");
            Console.WriteLine("Coke: " + cokePrice + " ₺");
            Console.WriteLine("Water: " + waterPrice + " ₺");
            Console.WriteLine("French Fries: " + frenchFriesPrice + " ₺");
            Console.WriteLine("Pizza: " + pizzaPrice + " ₺");
            Console.WriteLine("Lemonade: " + lemonadePrice + " ₺");
            Console.WriteLine();
            Console.WriteLine("***** Restaurant Menu Prices *****");
            Console.WriteLine();

            int hamburgerCount = 2;
            int cokeCount = 1;
            int waterCount = 3;
            int frenchFriesCount = 1;
            int pizzaCount = 1;
            int lemonadeCount = 2;

            Console.WriteLine("Total Hamburger Price: " + (hamburgerPrice * hamburgerCount) + " ₺");
            Console.WriteLine("Total Coke Price: " + (cokePrice * cokeCount) + " ₺");
            Console.WriteLine("Total Water Price: " + (waterPrice * waterCount) + " ₺");
            Console.WriteLine("Total French Fries Price: " + (frenchFriesPrice * frenchFriesCount) + " ₺");
            Console.WriteLine("Total Pizza Price: " + (pizzaPrice * pizzaCount) + " ₺");
            Console.WriteLine("Total Lemonade Price: " + (lemonadePrice * lemonadeCount) + " ₺");
            Console.WriteLine();

            int totalFoodPrice = (hamburgerPrice * hamburgerCount) + (cokePrice * cokeCount) + (waterPrice * waterCount) + (frenchFriesPrice * frenchFriesCount) + (pizzaPrice * pizzaCount) + (lemonadePrice * lemonadeCount);

            Console.WriteLine("Total Food Price: " + totalFoodPrice + " ₺");

            #endregion




            Console.Read();
        }
    }
}
