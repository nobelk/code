using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace StatisticsGenerator
{
    /** Statistics class that stores values and calculates stats Max and Avg */
    public class StatisticsGenerator
    {
        /** Output string when there are not enough values for calculating the stats */
        private const string NaN = "None";

        /** Separator to be used in console output */
        private const string separator = ", ";

        /** Prefix to be used in console output */
        private const string prefix = "(";

        /** Suffix to be used in console output */
        private const string suffix = ")";

        /** Queue to store incoming values */
        private Queue<int> dataStream = new Queue<int>();

        /** Array that stores all the rolling window sizes that this object implements */
        private int[] windowSizes;

        /** Default constructor */
        public StatisticsGenerator(int[] windowSizes)
        {
            this.windowSizes = windowSizes;
        }

        /** Method to add a incoming number to the datastream */
        public void Add(int number)
        {            
            if(this.dataStream.Count < this.windowSizes.Max())
            {
                this.dataStream.Enqueue(number);
            }
            else
            {
                this.dataStream.Dequeue();
                this.dataStream.Enqueue(number);
            }
        }

        /** Calculates maximum value for a given window size */
        public int GetMaximumValue(int windowSize)
        {
            int maxValue = Int32.MinValue;
            int[] dataArray = this.dataStream.ToArray();

            for(int index=dataArray.Length-1; index>dataArray.Length-1-windowSize; index--)
            {
                maxValue = Math.Max(maxValue, dataArray[index]);
            }

            return maxValue;
        }

        /** Calculates average value for a given window size */
        public double GetAverageValue(int windowSize)
        {
            int sum = 0;
            int[] dataArray = this.dataStream.ToArray();
            for(int index=dataArray.Length-1; index>dataArray.Length-1-windowSize; index--)
            {
                sum += dataArray[index];
            }

            return sum/(double)windowSize;
        }

        /** Checks boundary values and calculates the max value for a given window size and returns the string
        representation of the stat (None if the max value cannot be calculated for a given window size) */
        public string GetMaxValueString(int windowSize)
        {
            if(
                windowSize < 1
                ||
                this.dataStream.Count == 0
                ||
                windowSize > this.dataStream.Count
                )
            {
                return StatisticsGenerator.NaN;
            }

            return this.GetMaximumValue(windowSize).ToString();
        }

        /** Checks boundary values and calculates the avg value for a given window size and returns the string
        representation of the stat (None if the avg value cannot be calculated for a given window size) */
        public string GetAverageValueString(int windowSize)
        {
            if(
                windowSize < 1
                ||
                this.dataStream.Count == 0
                ||
                windowSize > this.dataStream.Count
                )
            {
                return StatisticsGenerator.NaN;
            }
            else if(
                this.dataStream.Count==1
                &&
                windowSize==1
            )
            {
                return this.dataStream.Peek().ToString();
            }

            return this.GetAverageValue(windowSize).ToString();
        }

        /** Method to get a list of statistics tuples */
        public string GetStatisctics()
        {
            StringBuilder outputBuilder = new StringBuilder();
            outputBuilder.Append(StatisticsGenerator.prefix);
            for(int index=0; index<this.windowSizes.Length; index++)
            {
                outputBuilder.Append(this.GetAverageValueString(this.windowSizes[index]));
                outputBuilder.Append(StatisticsGenerator.separator);
                outputBuilder.Append(this.GetMaxValueString(this.windowSizes[index]));

                if(index!=this.windowSizes.Length-1)
                {
                    outputBuilder.Append(StatisticsGenerator.separator);
                }
            }

            outputBuilder.Append(StatisticsGenerator.suffix);
            return outputBuilder.ToString();
        }
    }

    /** Driver class that is used to implement user I/O through the console and to display the results of calculating Max and Avg */
    public class StatisticsGeneratorDriver
    {
        static void Main(string[] args)
        {
            int[] inputDataStream = StatisticsGeneratorDriver.InputDataStream();
            int[] windowSize = new int[]{3,20};
            StatisticsGenerator stat = new StatisticsGenerator(windowSize);

            foreach(int input in inputDataStream)
            {
                stat.Add(input);        
                Console.WriteLine(stat.GetStatisctics());               
            }    
        }

        /** Helper method to gather user input of the datastream from console */
        public static int[] InputDataStream()
        {
            string dataStreamInput = Console.ReadLine();
            string formattedInput = dataStreamInput.Replace("[","");
            formattedInput = formattedInput.Replace("]", "");

            string[] inputNumberArray = formattedInput.Split(',');

            List<int> inputNumberList = new List<int>();

            foreach(string inputNumber in inputNumberArray)
            {
                inputNumberList.Add(Int32.Parse(inputNumber.Trim()));
            }

            return inputNumberList.ToArray();
        }
    }
}
