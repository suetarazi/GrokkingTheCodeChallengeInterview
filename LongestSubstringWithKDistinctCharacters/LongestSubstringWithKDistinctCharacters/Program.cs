using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace LongestSubstringWithKDistinctCharacters
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string testString = "araaci";
            int testDistinct = 1;
            Program p = new Program();
            int actual = p.findLength(testString, testDistinct);
            Console.WriteLine($"Output: The output is {actual}");
        }

        public int findLength(String str, int k)
        {
            //deal with your edge cases:
            if(str == null || str.Length == 0 || str.Length < k)
            {
                throw new ArgumentException();
            }

            int windowStart = 0;
            int maxSubstring = 0;
            Dictionary<char, int> charFrequency = new Dictionary<char, int>();

            //in this loop, we try and extend the width of the window [windowStart, windowEnd]            
            for(int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {

                char rightChar = str[windowEnd];
                Console.WriteLine($"Line 28: initial rightChar in for loop {rightChar}");

                //charFrequency[rightChar] += 1;

                if (!(charFrequency.ContainsKey(rightChar)))
                {
                    charFrequency[rightChar] = 0;
                    Console.WriteLine($"Line 45: charFrequency of rightChar {charFrequency[rightChar]}");

                }
                charFrequency[rightChar] += 1;
                Console.WriteLine($"Line 49: charFrequency of rightChar {charFrequency[rightChar]}");

                //Now try and shrink the sliding window until we have k distinct characters in the character frequency

                while (charFrequency.Count > k)
                {
                    char leftChar = str[windowStart];
                    Console.WriteLine($"Line 56: leftChar is {leftChar}");
                    charFrequency[leftChar] -= 1;

                        //if (charFrequency.ContainsKey(leftChar))
                        //{
                        //}
                        //charFrequency[leftChar] = 0;
                    
                    
                    if(charFrequency[leftChar] == 0)
                    {
                        charFrequency.Remove(leftChar);
                    }
                    windowStart++;
                }

                //window size is windowEnd - windowStart +1
                maxSubstring = Math.Max(maxSubstring, windowEnd - windowStart + 1);
                
            }

            return maxSubstring;
        }

    }
}
