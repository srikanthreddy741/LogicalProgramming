using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programming
{
    public class Fibonacci_Series
    {

       public static void PrintingFibonacci()
        {
            int n1 = 0, n2 = 1, n3, num;

            Console.WriteLine("Enter the number of Elements: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write(n1 + " " + n2 + " ");

            for (int i = 2; i < num; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");

                n1 = n2;
                n2 = n3;
            }
        }
    }
}
