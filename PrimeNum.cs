using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Assignment
{
    class PrimeNum
    {
        public static void Prime()
        {
            Console.WriteLine("Enter the Number N");
            int N = Convert.ToInt32(Console.ReadLine());
           if(N==2)
                Console.WriteLine(+N + " is a Prime Number");
            else if ((N%2== 0)||(N%3==0)||(N%5==0)||(N%7==0))
                Console.WriteLine(+N+" is Not a Prime Number");
            else
                Console.WriteLine(+N+" is a Prime Number");
        }
    }
}
