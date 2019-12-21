using System;

namespace InsertionSort
{
    class Program
    {

        public static int[] Sort(int[] array)
        {
            int inner, temp;
            int upper = array.Length - 1;
            for (int outer = 1; outer <= upper; outer++)
            {
                temp = array[outer];
                inner = outer;
                while (inner > 0 && array[inner - 1] >= temp)
                {
                    array[inner] = array[inner - 1];
                    inner--;
                }
                array[inner] = temp;

            }

            return array;
        }



        static void Main(string[] args)
        {
            int[] array = new int[] { 0, 2, 1, 6, 80, 10, 12 };
            int[] sortedArray = Program.Sort(array);

            for (int index = 0; index < sortedArray.Length; index++)
            {
                Console.Write(sortedArray[index] + " ");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
