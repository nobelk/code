using System;

namespace Sqrt
{
    class Program
    {

        public static double delta = 0.01;

        public static double FindSquareRoot(double number)
        {
            return FindSquareRootAux(0, number, number);
        }

        public static double FindSquareRootAux(double startNumber, double endNumber, double number)
        {
            double midPoint = (startNumber+endNumber)/2.0;
            Console.WriteLine(midPoint);
            
            double candidateDifference = midPoint*midPoint-number;

            if(
                candidateDifference==0 
            ||
            Math.Abs(candidateDifference)<=Program.delta)
            {
                return midPoint;
            }
            else if (candidateDifference>0)
            {
                return FindSquareRootAux(startNumber, midPoint, number);
            }
            else
            {
                return FindSquareRootAux(midPoint, endNumber, number);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Program.FindSquareRoot(100.0));
        }
    }
}
