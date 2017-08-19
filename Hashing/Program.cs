using System;

namespace Hashing
{

    class Program
    {

        public static string GetHashValue(string inputString)
        {
            string hashValue = null;

            if(string.IsNullOrEmpty(inputString))
            {

                return hashValue;
            }

            int currentIndex = 0;
            int hashValueInt = 0;
            while(currentIndex <= inputString.Length - 4 -1)
            {

                unchecked
                {
                    string hashComponent = inputString.Substring(currentIndex, 4);
                    foreach(byte value in System.Text.Encoding.ASCII.GetBytes(hashComponent))
                    {
                        hashValueInt += (int)value;
                    }
                }

                currentIndex += 4;
            }
            if(currentIndex<inputString.Length)
            {
                unchecked
                {
                    string hashComponent = inputString.Substring(currentIndex, inputString.Length-currentIndex);
                    foreach(byte value in System.Text.Encoding.ASCII.GetBytes(hashComponent))
                    {
                        hashValueInt += (int)value;
                    }
                }
            }

            return hashValueInt.ToString();
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Program.GetHashValue("Quickbrownfoxjumpsoveralazydog"));
        }
    }
}
