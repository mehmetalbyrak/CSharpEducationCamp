using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrays Foundations

            // int[] myArray = new int[5]; // --> Syntax
            //string[] colors = new string[7];
            //colors[0] = "Red";
            //colors[1] = "Blue";
            //colors[2] = "Yellow";
            //colors[3] = "Magenta";
            //colors[4] = "Orange";
            //colors[5] = "White";
            //colors[6] = "Brown";

            //Console.WriteLine(colors[5]);

            //foreach (var color in colors)
            //{
            //    Console.WriteLine(color);
            //}

            //string[] cities = new string[5];
            //cities[0] = "Madrid";
            //cities[1] = "Rome";
            //cities[2] = "Paris";
            //cities[3] = "Munich";
            //cities[4] = "Brussels";

            //cities.ToList().ForEach(city => Console.WriteLine(city));

            //int[] numbers = new int[10];
            //Console.WriteLine(numbers[5]); // --> 0

            //string[] countries = { "France", "Italy", "China", "Japan", "Egypt" };
            //Console.WriteLine(countries[3]); // --> Japan



            #endregion

            #region GetListOfAllElementsInArray

            //string[] teams = { "Arsenal", "Napoli", "Roma", "Sevilla", "Tottenham", "Porto", "Benfica" };
            //for (int i = 0; i < teams.Length; i++)
            //{
            //    Console.WriteLine(teams[i]);
            //}

            //int[] nums = { 4, 85, 96, 75, 125, 635, 488, 520, 7456, 2365, 1120 };
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 3 == 0)
            //    {
            //        Console.WriteLine(nums[i]);
            //    }
            //}


            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}



            //int[] myNumbers = { 47, 85, 95, 41, 25, 635, 789, 90, 100 };

            //int maxValue = myNumbers[0];

            //for (int i = 1; i < myNumbers.Length; i++)
            //{
            //    if (myNumbers[i] > maxValue)
            //    {
            //        maxValue = myNumbers[i];
            //    }
            //}

            //Console.WriteLine("Max value --> " + maxValue);


            //string[] persons = { "Figo", "Raul", "Juninho", "Pires", "Henry" };
            //Console.WriteLine(persons.Length); // --> 5

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine("------------------------");

            //int[] nums = { 21, 90, 73, 67, 990, 761, 71 };
            //Array.Sort(nums);
            //Array.Reverse(nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}






            #endregion

            #region ArrayMethods

            //string[] persons = { "Bale", "Neymar", "Diarra", "Mbappe", "Osimhen" };
            //int index = Array.IndexOf(persons, "Osimhen");
            //Console.WriteLine(index);


            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("max value: " + numbers.Max() + " min value: " + numbers.Min());

            #endregion

            #region Input from User


            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Please enter {i + 1}. city ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Entered Cities");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbersForSum = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbersForSum.Length; i++)
            //{
            //    sum += numbersForSum[i];
            //}
            //Console.WriteLine(sum);



            //int[] evenAndOddNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };


            //Console.WriteLine("Even Numbers :d ");
            //for (int i = 0; i < evenAndOddNumbers.Length; i++)
            //{
            //    if (evenAndOddNumbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine($"{evenAndOddNumbers[i]}");
            //    }
            //}

            //Console.WriteLine("Odd Numbers :d ");
            //for (int i = 0; i < evenAndOddNumbers.Length; i++)
            //{
            //    if (evenAndOddNumbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine($"{evenAndOddNumbers[i]}");
            //    }
            //}


            #endregion


            Console.Read();
        }
    }
}
