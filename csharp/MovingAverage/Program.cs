using System;
using System.Collections.Generic;

namespace MovingAverage
{
    public class MovingAverage
    {

        private int maxDataSize = 0;
        private int currentDataSize = 0;
        private int currentSum = 0;
        private Queue<int> dataQueue = new Queue<int>();

        /** Initialize your data structure here. */
        public MovingAverage(int size)
        {

            this.maxDataSize = size;
        }

        public double Next(int val)
        {
            if (currentDataSize < maxDataSize)
            {
                currentDataSize++;
                currentSum += val;
                dataQueue.Enqueue(val);

                return currentSum / (double)currentDataSize;
            }

            else
            {
                dataQueue.Enqueue(val);
                currentSum = currentSum - dataQueue.Dequeue() + val;
                return currentSum / (double)maxDataSize;
            }
        }
    }

    /**
     * Your MovingAverage object will be instantiated and called as such:
     * MovingAverage obj = new MovingAverage(size);
     * double param_1 = obj.Next(val);
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
