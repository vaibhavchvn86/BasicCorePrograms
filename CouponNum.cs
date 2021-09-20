using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Assignment
{
    class CouponNum
    {
        static char[] Num = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
        public static void Coupon()
        {
            Console.WriteLine("Enter N number of coupon: ");
            int N = Convert.ToInt32(Console.ReadLine());
                int CLength = 6;
                Random random = new Random();
                for (int CNum = 1; CNum <= N; CNum++)
                {
                    StringBuilder STRING = new StringBuilder();
                    for (int i = 0; i < CLength; i++)
                    {
                        int position = random.Next(0, Num.Length);
                        STRING.Append(Num[position]);
                    }
                    Console.WriteLine("Unique Coupon Number - {0}:  {1}", CNum, STRING);
                }
        }
    }
}
