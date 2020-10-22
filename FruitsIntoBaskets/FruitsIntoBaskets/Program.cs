using System;
using System.Collections.Generic;

namespace FruitsIntoBaskets
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //find the max fruit of two types (i.e. the largest width of sliding window)

        public int findLength(char[] arr)
        {
            int windowStart = 0;
            int maxSubstring = 1;

            Dictionary<char, int> fruitMap = new Dictionary<char, int>();

            //grow the window
            for(int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                char rightChar = arr[windowEnd];
               
                if(!fruitMap.ContainsKey(rightChar))
                {
                    fruitMap[rightChar] = 0;
                }
                fruitMap[rightChar] += 1;

            //now we try and shrink the window, keeping two distinct characters in the fruitMap
            while(fruitMap.Count > 2)
                {
                    char leftChar = arr[windowStart];

                    fruitMap[leftChar] -= 1;

                    if(fruitMap[leftChar] == 0)
                        {
                            fruitMap.Remove(leftChar);
                        
                        }

                        windowStart++;
                }
            maxSubstring = Math.Max(maxSubstring, windowEnd - windowStart + 1);
            }


            return maxSubstring;
        }
    }
}
