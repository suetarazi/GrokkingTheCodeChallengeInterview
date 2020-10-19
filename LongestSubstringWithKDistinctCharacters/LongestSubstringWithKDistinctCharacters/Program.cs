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
        }

        public int findLength(String str, int k)
        {
            //deal with your edge cases:
            if(str == null || str.Length == 0 || str.Length < k)
            {
                throw new ArgumentException();
            }

            int windowStart = 0;
            int maxSubstring = Int32.MinValue;
            Dictionary<char, int> hashmap = new Dictionary<char, int>();

            //in this loop, we try and extend the width of the window [windowStart, windowEnd]            
            for(int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {

                char rightChar = str[windowEnd];

                hashmap.Add(rightChar, hashmap.TryGetValue(rightChar) + 1);
                
                while(hashmap.Count > k)
                {
                    char leftChar = str[windowStart];

                    hashmap.Add(leftChar, hashmap[leftChar] -1;   
                    
                    if(hashmap.TryGetValue(leftChar) == 0)
                    {
                        hashmap.Remove(leftChar);
                    }
                    windowStart++;
                }

                maxSubstring = Math.Max(maxSubstring, windowEnd - windowStart + 1);
            }

            return maxSubstring;
        }

    }
}
