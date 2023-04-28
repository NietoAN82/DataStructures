using System;
using System.Collections.Generic;


namespace DataStructures
{
    internal class Queues
    {
        public static void Main(string[] args)
        {
            //Initializing a queue
            Queue<string> queue = new Queue<string>();
            //Enqueue adds an element to the queue
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");

            //Dequeue removes element from queue
            System.Diagnostics.Debug.WriteLine(queue.Dequeue());

            //Peek allows you to view the element at the top of the queue.
            System.Diagnostics.Debug.WriteLine(queue.Peek());
        }
    }
}
