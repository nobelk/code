using System;

namespace MyPow
{

    /** 
    Implement the mypow function
    
     */
    class Program
    {

        public static double MyPow(double x, int n)
        {

            if (n == 0)
                return 1;

            if (n < 0)
            {
                n *= -1;
                x = 1 / x;
            }

            return n % 2 == 0 ? MyPow(x * x, n / 2) : x * MyPow(x * x, n / 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MyPow(8.88, 3));
        }
    }
}
