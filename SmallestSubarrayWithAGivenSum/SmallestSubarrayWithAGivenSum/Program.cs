using System;

namespace SmallestSubarrayWithAGivenSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int findMinSubArray(int S, int[] arr)
        {
            int minSum = 0;
            int windowSum = 0;
            int windowStart = 0;

            for(int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                windowSum += arr[windowEnd];
            }
            if(windowSum <= S)
            {
                minSum = Math.Min(minSum, windowSum);


            }
            
            return 0;
        }
    }
}
