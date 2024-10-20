using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region void Methods

            //void CustomerList()
            //{
            //    Console.WriteLine("Leyla");
            //    Console.WriteLine("Selin");
            //    Console.WriteLine("Pelin");
            //    Console.WriteLine("Gizem");
            //};

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;

            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();



            #endregion

            #region Void Methods with parameters (string)

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string lastName)
            //{
            //    Console.WriteLine($"Customer name: {name} Customer lastname: {lastName}");
            //}

            //CustomerCard("Leylah","Fernandez");


            #endregion

            #region Void Methods with parameters (int)

            //void Sum(int num1, int num2, int num3)
            //{
            //    int result = num1 + num2 + num3;
            //    Console.WriteLine(result);
            //}

            //Sum(1, 5, 9);

            #endregion

            #region Methods that return a value (string)

            //string CustomerName()
            //{
            //    return "Femke Bol";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string lastName = "Kaya";

            //    string totalName = name + " " + lastName;

            //    return totalName;

            //}

            //Console.WriteLine(StudentCard());




            #endregion

            #region Methods that return a value (string) with parameter

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = " Country Name: " + countryName + " Capital: " + capital + " Flag Color: " + flagColor;
            //    return cardInfo;
            //}

            //Console.WriteLine("Please enter country name :d");
            //string enteredCountry = Console.ReadLine();

            //Console.WriteLine("please enter capital");
            //string enteredCapital = Console.ReadLine();

            //Console.WriteLine("please enter flag color :d");
            //string enteredFlagColor = Console.ReadLine();

            //Console.WriteLine(CountryCard(enteredCountry, enteredCapital, enteredFlagColor));
            //Console.WriteLine(CountryCard("Finland", "Helsinki", "Blue-White"));


            #endregion

            #region Methods that return a value (int) with parameter

            //int Sum(int num1, int num2)
            //{
            //    int result = num1 + num2;
            //    return result;
            //}

            //Console.WriteLine(Sum(3, 5));
            //Console.WriteLine(Sum(70, 45));



            #endregion


            #region Methods that return a value (int) with parameter v2

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return $"Average is {result} and {student} --> is successful";
                }
                else
                {
                    return $"Average is {result} and {student} --> is failed";
                }
            }

            Console.WriteLine(ExamResult("Halsey", 75, 16, 100));

            #endregion


            Console.Read();
        }
    }
}
