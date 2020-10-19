using System;
using System.Collections.Generic;
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
            HashSet<char> hashmap = new HashSet<char>();
            
            for(int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                maxSubstring += str[windowEnd];
                hashmap.Add(maxSubstring);
                int linqQuery = Select(maxSubstring).Distinct
            }
            return -1;
        }

    }
}
