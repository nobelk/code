using System;

namespace Palindrome
{
    class Program
    {

    public static bool IsPalindrome(string input)
    {
        if(input==null)
        {
            return false;
        }

        if(input.Length==0)
        {
            return true;
        }

        int index1 = 0;
        int index2 = input.Length - 1;

        while(index1 < index2)
        {
            if(input[index1]!=input[index2])
            {
                return false;
            }
            else
            {
                index1++;
                index2--;
            }
        }

        return true;
    }


        static void Main(string[] args)
        {
            Console.WriteLine(Program.IsPalindrome("aa"));
        }
    }
}
