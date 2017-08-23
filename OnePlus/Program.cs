using System;

namespace OnePlus
{

    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {

            int[] plusOneNumber = new int[digits.Length];

            int sum = 0;
            int carry = 0;
            int currentDigit = 0;
            for (int index = digits.Length - 1; index >= 0; index--)
            {
                if (index == digits.Length - 1)
                {
                    sum = digits[index] + 1;
                }
                else
                {
                    sum = digits[index] + carry;
                }


                if (sum == 10)
                {
                    carry = 1;
                    currentDigit = 0;
                }
                else
                {
                    carry = 0;
                    currentDigit = sum;
                }

                plusOneNumber[index] = currentDigit;

                if (index == 0 && carry == 1)
                {
                    int[] plusOneNumberTmp = new int[digits.Length + 1];
                    for (int cIndex = plusOneNumber.Length - 1; cIndex > 0; cIndex--)
                    {
                        plusOneNumberTmp[cIndex] = plusOneNumber[cIndex];
                    }

                    plusOneNumberTmp[0] = 1;

                    return plusOneNumberTmp;
                }
            }

            return plusOneNumber;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
