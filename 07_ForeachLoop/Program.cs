using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Usage --> Intro

            //string[] cities = { "Milano", "Rome", "Ankara", "London", "Madrid" };

            //foreach (var item in cities)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("--------- Even Numbers on array ------------ ");

            //foreach (var item in numbers)
            //{
            //    if (item %2 == 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            //Console.WriteLine("-------------- Sum of Array Elements ----------------");
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //int sum = 0;
            //foreach (int i in numbers)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum); // --> 120


            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 8 };

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "Hello";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}








            #endregion

            #region Sample Exam System Application

            Console.WriteLine("********** C# Camping Exam ***********");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("How many students are there in class?");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");

            string[] studentNames = new string[studentCount];
            double[] studentExamAverage = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Enter the name of student {i + 1}:");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Enter exam note {j + 1} for {studentNames[i]}:");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; // Adding notes
                }

                
                studentExamAverage[i] = totalExamResult / 3;

                
                Console.WriteLine($"{studentNames[i]}'s average is {studentExamAverage[i]:F2}");
                if (studentExamAverage[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} has passed.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} has failed.");
                }
                Console.WriteLine("--------------------------------");
            }

            
            Console.WriteLine("Summary of results:");
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} - Average: {studentExamAverage[i]:F2}");
            }

            #endregion

            Console.Read();

        }
    }
}
