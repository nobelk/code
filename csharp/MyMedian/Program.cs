using System;

namespace MyMedian
{

    public class MyMedian
    {

        private int[] data = new int[10];

        private int currentSize = 0;

        public MyMedian()
        {

        }

        public void Add(int value)
        {
            // boundary condition
            if(currentSize==this.data.Length-1)
            {
                Array.Resize(ref this.data, this.data.Length*2);
            }


            // calculate position
            int insertIndex = 0;

            while(insertIndex<this.data.Length)
            {
                if(value<this.data[insertIndex] || insertIndex>=this.currentSize)
                {
                    break;
                }

                insertIndex++;
            }

            for(int index=currentSize; index>insertIndex; index--)
            {
                this.data[index] = this.data[index-1];
            }
            
            // insert data
            // increment size
            this.data[insertIndex]=value;
            this.currentSize++;
       }

       public double GetMedian()
       {
           if(this.currentSize==0)
           {
               return 0;
           }
           else if(this.currentSize==1)
           {
               return this.data[0];
           }
           else if(this.currentSize%2==0)
           {
                return (double)(this.data[this.currentSize/2]+this.data[(this.currentSize/2)-1])/2.0d;
           }
           else
           {
               return (double)this.data[this.currentSize/2];
           }
       }

    }


    class Program
    {
        static void Main(string[] args)
        {

            MyMedian m = new MyMedian();
            m.Add(2);
            m.Add(100);
            m.Add(1000);
            Console.WriteLine(m.GetMedian());
        }
    }
}
