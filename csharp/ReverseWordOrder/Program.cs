using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseWordOrder
{
    class Program
    {
        public static string ReverseWordOrder(string sentence)
        {
            // initialize
            StringBuilder sentenceBuilder = new StringBuilder();


            // form reverse string
            string[] sentenceArray = sentence.Split(' ');

            // build reverse string
            for(int index=sentenceArray.Length-1; index>=0; index--)
            {
                sentenceBuilder.Append(sentenceArray[index]);
                if(index>0)
                {
                    sentenceBuilder.Append(" ");
                }
            }

            // result
            return sentenceBuilder.ToString();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(Program.ReverseWordOrder("Quick brown fox jumps over a lazy dog"));

        }
    }
}
