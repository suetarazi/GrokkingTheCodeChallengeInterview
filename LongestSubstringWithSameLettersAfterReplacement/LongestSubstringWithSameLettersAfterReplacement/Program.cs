using System;

namespace LongestSubstringWithSameLettersAfterReplacement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int findLength(String str, int k)
        {
            int windowStart = 0;
            int maxSubstring = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();

            for(int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {


            }

            maxSubstring = Math.Max(maxSubstring, windowStart - windowEnd + 1);


            return maxSubstring;
        }
    }
}
