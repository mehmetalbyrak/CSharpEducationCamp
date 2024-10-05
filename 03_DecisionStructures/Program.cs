using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DecisionStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region if usage
            //Console.WriteLine("Welcome to If Universe");
            //Console.WriteLine("Please enter password: ");
            //string enteredPassword = Console.ReadLine();
            //if (enteredPassword == "abcd")
            //{
            //    Console.WriteLine("Correct password :d");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong password !!!");
            //}


            //string capital, country;
            //Console.WriteLine("Enter capital: ");
            //capital = Console.ReadLine();

            //Console.WriteLine("Enter country: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" && country == "türkiye")
            //{
            //    Console.WriteLine("Data are verified");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong information");
            //}


            //int num;
            //Console.WriteLine("Enter number:");
            //num = int.Parse(Console.ReadLine());

            //if (num == 5)
            //{
            //    Console.WriteLine("Number is correct :d");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong number !!!");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Error";

            //Console.WriteLine("Exam 1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Exam 2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Exam 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Average: " + average);

            //if (average > 0 && average < 50)
            //{
            //    result = "Failed";
            //}
            //if (average >= 50 && average < 70)
            //{
            //    result = "Medium";
            //}
            //if (average >= 70 && average < 85)
            //{
            //    result = "Good";
            //}
            //if (average >= 85 && average <= 100)
            //{
            //    result = "Excellent";
            //}

            //Console.WriteLine("Result: " + result);


            //string city;
            //Console.WriteLine("Enter city: ");
            //city = Console.ReadLine();

            //if (city == "adana" || city == "mersin" || city == "hatay")
            //{
            //    Console.WriteLine("Region: Mediterranean");
            //}
            //else if (city == "istanbul" || city == "bursa" || city == "kocaeli")
            //{
            //    Console.WriteLine("Region: Marmara");
            //}
            //else if (city == "ankara" || city == "konya" || city == "eskisehir")
            //{
            //    Console.WriteLine("Region: Central Anatolia");
            //}
            //else if (city == "izmir" || city == "aydin" || city == "manisa")
            //{
            //    Console.WriteLine("Region: Aegean");
            //}
            //else
            //{
            //    Console.WriteLine("Region: Unknown");
            //}

            //Console.WriteLine("Please enter a username: ");
            //string username = Console.ReadLine();

            //if (username == "admin")
            //{
            //    Console.WriteLine("Welcome Admin");
            //}
            //else
            //{
            //    Console.WriteLine("Unauthorized Access !!!");
            //}

            #endregion

            #region Mod usage

            //Console.WriteLine("Please enter number :d");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Number is even");
            //}
            //if(num % 2 != 0)
            //{
            //    Console.WriteLine("Number is odd");
            //}

            


            //Console.WriteLine("Please enter a number1 :d");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter a number2 :d");
            //int num2 = int.Parse(Console.ReadLine());

            //int result = num1 % num2;

            //Console.WriteLine("Result: " + result);

            #endregion

            #region char usage with decisions

            //char team;
            //Console.WriteLine("Please enter a team symbol: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'G' || team == 'g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'F' || team == 'f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'B' || team == 'b')
            //{
            //    Console.WriteLine("Besiktaş");
            //}


            #endregion

            #region Sample Project Application

            //Console.WriteLine("***** C# Education Camp Food Menu *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");

            //Console.WriteLine("1. Main Foods");
            //Console.WriteLine("2. Soups");
            //Console.WriteLine("3. Pizzas");
            //Console.WriteLine("4. Drinks");
            //Console.WriteLine("5. Desserts");
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Please select a menu item: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine("---------Main Foods---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1. Meatball");
            //    Console.WriteLine("2. Chicken");
            //    Console.WriteLine("3. Fish");
            //    Console.WriteLine("4. Steak");
            //    Console.WriteLine("5. Salad");
            //    Console.WriteLine("---------Main Foods---------");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine("---------Soups---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1. Lentil Soup");
            //    Console.WriteLine("2. Chicken Soup");
            //    Console.WriteLine("3. Tomato Soup");
            //    Console.WriteLine("4. Mushroom Soup");
            //    Console.WriteLine("5. Vegetable Soup");
            //    Console.WriteLine("---------Soups---------");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine("---------Pizzas---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1. Mixed Pizza");
            //    Console.WriteLine("2. Salami Pizza");
            //    Console.WriteLine("3. Vegetarian Pizza");
            //    Console.WriteLine("4. Seafood Pizza");
            //    Console.WriteLine("5. Cheese Pizza");
            //    Console.WriteLine("---------Pizzas---------");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine("---------Drinks---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1. Cola");
            //    Console.WriteLine("2. Fanta");
            //    Console.WriteLine("3. Sprite");
            //    Console.WriteLine("4. Ice Tea");
            //    Console.WriteLine("5. Water");
            //    Console.WriteLine("---------Drinks---------");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine("---------Desserts---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1. Baklava");
            //    Console.WriteLine("2. Rice Pudding");
            //    Console.WriteLine("3. Chocolate Cake");
            //    Console.WriteLine("4. Profiterole");
            //    Console.WriteLine("5. Ice Cream");
            //    Console.WriteLine("---------Desserts---------");
            //}



            //Console.ReadLine();
            #endregion

            #region Switch Case

            //Console.WriteLine("Please enter Month Number: ");
            //int month = int.Parse(Console.ReadLine());

            //switch (month)
            //{
            //    case 1:Console.WriteLine("January"); break;
            //    case 2: Console.WriteLine("February"); break;
            //    case 3: Console.WriteLine("March"); break;
            //    case 4: Console.WriteLine("April"); break;
            //    case 5: Console.WriteLine("May"); break;
            //    case 6: Console.WriteLine("June"); break;
            //    case 7: Console.WriteLine("July"); break;
            //    case 8: Console.WriteLine("August"); break;
            //    case 9: Console.WriteLine("September"); break;
            //    case 10: Console.WriteLine("October"); break;
            //    case 11: Console.WriteLine("November"); break;
            //    case 12: Console.WriteLine("December"); break;
            //    default: Console.WriteLine("Unknown Month"); break;
            //}

            //Console.ReadLine();

            #endregion

            #region Switch Case Calculator

            //int num1, num2, result;
            //char symbol;

            //Console.WriteLine("Please enter first number: ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter second number: ");
            //num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter symbol: ");
            //symbol = char.Parse(Console.ReadLine());


            //switch (symbol)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        Console.WriteLine("Result: " + result);
            //        break;

            //    case '-':
            //        result = num1 - num2;
            //        Console.WriteLine("Result: " + result);
            //        break;

            //    case '*':
            //        result = num1 * num2;
            //        Console.WriteLine("Result: " + result);
            //        break;

            //    case '/':
            //        result = num1 / num2;
            //        Console.WriteLine("Result: " + result);
            //        break;
            //}


            //Console.ReadLine();
            #endregion
        }
    }
}
