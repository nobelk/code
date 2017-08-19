using System;

namespace BubbleSort
{

    class Program
    {

        public static int[] Sort(int[] array)
        {
            bool itemSwapped = true;
            int currentValueIndex = 0;

            while(itemSwapped && currentValueIndex < array.Length)
            {
                itemSwapped = false;
                for(int index=currentValueIndex+1; index<array.Length; index++)
                {
                    if(array[currentValueIndex] > array[index])
                    {
                        int temp = array[index];
                        array[index] = array[currentValueIndex];
                        array[currentValueIndex] = temp;
                        itemSwapped = true;
                    }
                }
                currentValueIndex++;
            }

            return array;
        }

        static void Main(string[] args)
        {
            int[] input = new int[]{1, 200, 4, 3, 5, 6, 0};

            Console.WriteLine("Hello World!");

            int[] sortedInput = Program.Sort(input);

            for(int index=0; index<sortedInput.Length; index++)
            {
                Console.Write(sortedInput[index] + " ");
            }
        }
    }
}
