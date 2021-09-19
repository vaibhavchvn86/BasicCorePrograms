using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Assignment
{
    class ReverseNum
    {
        public static void Reverse()
        {
            Console.WriteLine("Enter the Number to Reverse");
            int N = Convert.ToInt32(Console.ReadLine());
           
            int Rev = 0;
            while (N!=0)
            {
               int R = N % 10;
                
                Rev = (Rev * 10 )+ R;
                N /= 10;
            }
            Console.WriteLine(+Rev);

        }
    }
}
