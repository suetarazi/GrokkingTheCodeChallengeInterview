using System;
using System.Collections.Generic;

namespace ShortestPathLength
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int shortestPathLength(Node start, Node end)
        {
            // Start at the start
            // Create a set of nodes S that are reachable from start
            // Create a set of nodes S' thar are reachable from S and have not yet been in any set
            // Repeat until you reach end
            // Return number of sets (+/-1?)



            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(start); //{0,0}




            return -1;

        }
    }
}
