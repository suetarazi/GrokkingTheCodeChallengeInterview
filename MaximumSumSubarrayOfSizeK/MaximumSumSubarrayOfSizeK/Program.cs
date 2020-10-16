using System;

namespace MaximumSumSubarrayOfSizeK
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int findMaxSumSubArray(int k, int[] arr)
        {

            int maxSum = 0;
            int currentSum;

            for (int i = 0; i <= (arr.Length - k); i++)
            {
                currentSum = 0;
                for (int j = i; j < (i + k); j++)
                {
                    currentSum += arr[j];
                }
                maxSum = Math.Max(maxSum, currentSum);
            }
            return maxSum;
        }

        public int findMaxSumSubArrayOptimized(int k, int[] arr)
        {
            int maxSum = 0;


            return maxSum;
        }


    }
}
