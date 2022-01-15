using System;
using System.Collections;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue MyQueue = new Queue(); //initialize a new Queue

            MyQueue.Enqueue(1);// insert element in the Queue
            MyQueue.Enqueue(2);
            MyQueue.Enqueue(3);
            MyQueue.Enqueue(4);


            Console.WriteLine("this is all the elmenet in the Queue...");
            foreach(int item in MyQueue) // print all the elements
                Console.WriteLine(item);

            Console.WriteLine("\ntotal number of queue is: " + MyQueue.Count); //return total number of elements

            Console.WriteLine("\nthe first element in the queue : " + MyQueue.Peek()); //return the first element

            Console.WriteLine("\nthis element is removed! :" + MyQueue.Dequeue()); //remove the first element

            Console.WriteLine("\ntotal number of queue is (updated): " + MyQueue.Count); //return total number of elements

            Console.WriteLine("\nthis is all the elmenet in the Queue (Updated)");

            foreach (int item in MyQueue) // print all the elements 
                Console.WriteLine(item);

        }
    }
}
