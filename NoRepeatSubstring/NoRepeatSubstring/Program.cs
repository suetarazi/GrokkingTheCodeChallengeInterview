using System;
using System.Collections.Generic;

namespace NoRepeatSubstring
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //find the length of the longest substring which has no repeating characters
        public int findLength(string str)
        {
            int windowStart = 0;
            int maxSubstring = 1;

            List<char> charList = new List<char>();

            //grow the window
            for(int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                char rightChar = str[windowEnd];

                if(charList.Contains(rightChar))
                {
                    windowStart = rightChar;
                }                
                charList.Add(rightChar);



                maxSubstring = Math.Max(maxSubstring, windowEnd - windowStart + 1);
            }


            return maxSubstring;
        }

    }
}
