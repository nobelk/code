using System;

namespace ReverseWordOrderWoSpace
{
    class Program
    {

        public static string ReverseWordOrder(string input)
        {
            string reversedString = ReverseString(input,0,input.Length-1);
            char[] inputCharArray = reversedString.ToCharArray();

            for(int i=0, j=0; j<inputCharArray.Length; j++)
            {
                if(inputCharArray[j]!=' ')
                {
                    continue;
                }
                else
                {
                    inputCharArray=ReverseString(inputCharArray.ToString(), i, j-1).ToCharArray();
                    i = j;
                }
            }
            
            return inputCharArray.ToString();
        }

        public static string ReverseString(string input, int i, int j)
        {
            char[] inputCharArray = input.ToCharArray();
            while(j>i)
            {
                char temp = input[j];
                inputCharArray[j] = input[i];
                inputCharArray[i] = temp;

                j--;
                i++;
            }

            return inputCharArray.ToString();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Program.ReverseWordOrder("Hello World"));
        }
    }
}
