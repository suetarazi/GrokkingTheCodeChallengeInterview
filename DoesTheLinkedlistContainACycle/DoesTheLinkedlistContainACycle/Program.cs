using System;

namespace DoesTheLinkedlistContainACycle
{
    public class LinkedListNode
    {
        public int Value { get; set; }

        public LinkedListNode Next { get; set; }

        public LinkedListNode(int value)
        {
            Value = value;
        }
    }


    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool ContainsCycle(LinkedListNode linkedList)
        {
            if(linkedList.Next == null)
            {
                return false;
            }

        }
    }
}
