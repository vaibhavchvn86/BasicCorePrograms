using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Assignment
{
    class FibonacciNum
    {
        public static void Fibnum()
        {
            int b=1;
            int a=0;
            int N;
            int c=0;
            int i;
            int d = 0;

            Console.WriteLine("Enter the Number to find Fibonacci Series till N");
            N = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Fibnum " + d);
            for (i = 2; i <= N; i++)
            {
                c = a + b;
                Console.WriteLine("Fibnum " + c);
                a = b;
                b = c;
            }
        }
        }
    }

