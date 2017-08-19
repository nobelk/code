using System;

namespace TwoNumberSum
{
    class Program
    {

        public static int[] FindIndex(int[] array, int sum)
        {
            int[] indices = new int[2];

            for (int index1 = 0; index1 < array.Length; index1++)
            {

                for (int index2 = index1 + 1; index2 < array.Length; index2++)

                {

                    if (array[index1] + array[index2] == sum)
                    {
                        if(index1 < index2)
                        {
                            indices[0]=index1+1;
                            indices[1]=index2+1;
                        }
                        else
                        {
                            indices[1]=index1+1;
                            indices[0]=index2+1;
                        }

                        return indices;
                    }
                }
            }

            return indices;

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] input = new int[] {0, 3, 44, 5, 234, 0, -1, -3, -200, -99, 88};
            int[] indices = Program.FindIndex(input, 87);

            foreach (int index in indices)
            {
                Console.WriteLine(index);
            }
        }
    }
}
