using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // for ₺ symbol

            #region Double variables

            //double number;
            //number = 4.85;
            // Console.WriteLine(number);

            //Console.WriteLine("***** Price List *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----- Apple Unit Price :" + applePrice + " ₺");
            //Console.WriteLine("----- Orange Unit Price :" + orangePrice + " ₺");
            //Console.WriteLine("----- Strawberry Unit Price :" + strawberryPrice + " ₺");
            //Console.WriteLine("----- Potato Unit Price :" + potatoPrice + " ₺");
            //Console.WriteLine("----- Tomato Unit Price :" + tomatoPrice + " ₺");
            //Console.WriteLine();



            //double appleKilogram = 1.245;
            //double orangeKilogram = 2.650;
            //double strawberryKilogram = 0.750;
            //double potatoKilogram = 4.859;
            //double tomatoKilogram = 3.745;


            //double totalApplePrice = applePrice * appleKilogram;
            //double totalOrangePrice = orangePrice * orangeKilogram;
            //double totalStrawberryPrice = strawberryPrice * strawberryKilogram;
            //double totalPotatoPrice = potatoPrice * potatoKilogram;
            //double totalTomatoPrice = tomatoPrice * tomatoKilogram;


            //double shoppingTotalPrice = totalApplePrice + totalOrangePrice + totalStrawberryPrice + totalPotatoPrice + totalTomatoPrice;

            //Console.WriteLine("----- Total Apple Price :" + totalApplePrice + " ₺ " + " --> Total Apple Gram " + appleKilogram * 1000 + " gr");
            //Console.WriteLine("----- Total Orange Price :" + totalOrangePrice + " ₺ " + " --> Total Orange Gram " + orangeKilogram * 1000 + " gr");
            //Console.WriteLine("----- Total Strawberry Price :" + totalStrawberryPrice + " ₺ " + " --> Total Strawberry Gram " + strawberryKilogram * 1000 + " gr");
            //Console.WriteLine("----- Total Potato Price :" + totalPotatoPrice + " ₺ " + " --> Total Potato Gram " + potatoKilogram * 1000 + " gr");
            //Console.WriteLine("----- Total Tomato Price :" + totalTomatoPrice + " ₺ " + " --> Total Tomato Gram " + tomatoKilogram * 1000 + " gr");
            //Console.WriteLine();
            //Console.WriteLine("----- Total Price :" + shoppingTotalPrice + " ₺");
            //Console.WriteLine();


            #endregion

            #region Char variables

            // ABCDE --> DEFGH  : Sezar encryption
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            //Console.WriteLine();

            #endregion

            #region Data Entries From Keyboard --> String

            //Console.WriteLine("**** C# Air Way Passenger Informations *****");
            //string passengerName, passengerLastName, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Passenger Name: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Passenger Last Name: ");
            //passengerLastName = Console.ReadLine();

            //Console.WriteLine("Passenger Full Name: " + passengerName + " " + passengerLastName);

            //Console.Write("Passenger District: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Passenger City: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Passenger Age: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Passenger Identity Number: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine("Passenger Full Name: " + passengerName + " " + passengerLastName + " Passenger District: " + passengerDistrict + " Passenger City: " + passengerCity + " Passenger Age: " + passengerAge + " Passenger Identity Number: " + passengerIdentityNumber);

            #endregion

            #region Data Entries From Keyboard --> Int & Type Conversions

            // ABC12D

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Please enter the number of shoes: ");
            //shoesCount = Convert.ToInt32(Console.ReadLine());


            //Console.Write("Please enter the number of computers: ");
            //computerCount = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please enter the number of chairs: ");
            //chairCount = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please enter the number of TVs: ");
            //tvCount = Convert.ToInt32(Console.ReadLine());

            //int totalShoePrice = shoePrice * shoesCount;
            //int totalComputerPrice = computerPrice * computerCount;
            //int totalChairPrice = chairPrice * chairCount;
            //int totalTvPrice = tvPrice * tvCount;

            //int totalShoppingPrice = totalShoePrice + totalComputerPrice + totalChairPrice + totalTvPrice;

            //Console.WriteLine("Total Shopping Price: " + totalShoppingPrice + " ₺");





            #endregion

            #region Data Entries From Keyboard --> Double & Type Conversions

            //double exam1, exam2, exam3, result;
            //Console.Write("Please enter the first exam result: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Please enter the second exam result: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Please enter the third exam result: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Student's average: " + result);

            #endregion

            #region Data Entries From Keyboard --> Char & Type Conversions

            char gender;
            Console.Write("Please enter gender (M/F):");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Chosen gender : " + gender);

            #endregion



            Console.Read();


        }
    }
}
