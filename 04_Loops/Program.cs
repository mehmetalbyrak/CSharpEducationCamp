using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Loop
            // For(x;y;z)
            // x: begin, y: end, z: increment-decrement

            //int i;

            //for (i = 1; i <= 5;  i++)
            //{
            //    Console.WriteLine("C# Education Camp");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 3; i <= 50 ; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Please enter the number you want to be written on the screen :d");
            //int enteredValue = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= enteredValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}


            #endregion

            #region For Loops with decisions

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i %5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int sum = 0;

            //for (int i = 0; i <= 10; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);


            //int sumOfEvens = 0;

            //for (int i = 0; i < 20; i++)
            //{
            //    if (i %2 == 0)
            //    {
            //        sumOfEvens += i;
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("--");
            //Console.WriteLine(sumOfEvens);

            //int count = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("--");
            //Console.WriteLine(count);

            //// Bacteria example --> 1-2-4-8

            //int numberOfBacterias = 1;

            //for (int i = 1; i <= 24;  i++)
            //{
            //    numberOfBacterias *= 2;
            //}
            //Console.WriteLine(numberOfBacterias); // 16777216


            #endregion

            #region While Loop

            // While(Condition)
            //{
            // process
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Hello Loops :d");
            //    i++;
            //}

            //int i = 1;

            //while (i < 10)
            //{
            //    if (i %3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            //int sum = 0;
            //int i = 1;

            //while(i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Example Exam Question

            //// Write the code that calculates the sum of the digits of a 3-digit number entered from the keyboard

            //Console.WriteLine("Please enter 3 digit number :d");
            //int enteredNum = int.Parse(Console.ReadLine());

            //int sum = 0;
            //int firstDigit = enteredNum % 10;
            //int secondDigit = (enteredNum / 10) % 10; // my approach for second digit :d
            //int thirdDigit = (enteredNum / 100);
            //sum = firstDigit + secondDigit + thirdDigit;
            //Console.WriteLine(sum);

            #endregion

            Console.Read();
        }
    }
}
