using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Assignment
{
    class PerfectNum
    {
        public static void Num()
        { 
            Console.WriteLine("Enter the Number N");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < N; i++)
            {
                if (N % i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine("Divisor of N = " +i);
                }
            }
            if (sum == N)
            {
                Console.WriteLine("Entered number "+N +" is a perfect number");  
            }
            else
            {
                Console.WriteLine("Entered number "+N+" is not a perfect number");
            }
        }
    }
    
}
