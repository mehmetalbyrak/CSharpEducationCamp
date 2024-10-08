using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 10 Stars (under each other)

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region 10 Stars (side by side)

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region 10 Stars --> under each other and 10 stars in each line

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("*");
            //}

            #endregion

            #region 10 Stars --> Right Triangle

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region 10 Stars --> Reverse Right Triangle

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 10; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region Right Triangle & Reverse Right Triangle

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i <= 5)
            //    {
            //        for (int j = 1; j <= i; j++)
            //        {
            //            Console.Write("*");
            //        }

            //        Console.WriteLine();

            //        if (i > 5)
            //        {
            //            for (int j = 10; j > i; j--)
            //            {
            //                Console.Write("*");
            //            }

            //            Console.WriteLine();
            //        }
            //    }

            #endregion


            #region Baklava Slice

            //int n = 5;


            //for (int i = 1; i <= n; i++)
            //{

            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }


            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}


            //for (int i = n - 1; i >= 1; i--)
            //{

            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }


            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region Pyramid

            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    // for blanks
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    // for stars
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Reverse Pyramid

            //int n = 5;

            //for (int i = n; i >= 1; i--)
            //{
                
            //    for (int j = n-i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

                
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

                
            //    Console.WriteLine();
            //}

            #endregion



            // Console.Read();
            
        }
    }
}

