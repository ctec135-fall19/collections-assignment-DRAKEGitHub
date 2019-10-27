/* 
 Author: Allison Drake
 CTEC 165 Fall 2019
 Programming Assignment 4 Problem 2
 
 Stacks and Queues

 All code in Main()
 Regions: Stack and Queue

 STACK: declare and initialize stack with numbers 1-5 using 
 initalization syntax
 - demonstrate use of enumerator/foreach to print out members in stack
 - write a foreach loop
 - print a peek at the top member in the stack
 - write a loop that pops the elements off the stack and prints each

 QUEUE: declare a queue
 - initialize the queue with numbers 1-5 using a for loop
 - demonstrate use of the enumrator/foreach to print out members of queue
 - print a peek at the top member of the stack
 - write a loop that dequeues the elements from the stack and prints each

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region STACK

            Console.WriteLine("STACKS");
            // declare a stack and initialize with syntax
            Stack<int> numbers = new Stack<int>();
            numbers.Push(5);
            numbers.Push(4);
            numbers.Push(3);
            numbers.Push(2);
            numbers.Push(1);
            Console.WriteLine("Current count of stack numbers is: {0}.", numbers.Count);
            Console.WriteLine();
            // use enumerator/foreach to print stack
            Console.WriteLine("Stack numbers printed in LIFO:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // print peek at the top of the Stack
            Console.WriteLine("Element at the top of numbers is: " + numbers.Peek());
            Console.WriteLine();

            // loop that pops the elements from the stack and prints each
            Console.WriteLine("Popping numbers:");
            int size = numbers.Count;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(numbers.Pop());
            }
            // print count of numbers after popping
            Console.WriteLine("Current count of numbers after popping is: {0}.", numbers.Count);
            Console.WriteLine();
            #endregion

            #region QUEUE
            Console.WriteLine("QUEUES");
            // declare a queue
            Queue<int> numberQueue = new Queue<int>(5);

            // intiialize queue with 1-5 using a for loop
            for(int x = 0; x < size; x++)
            {
                numberQueue.Enqueue(x + 1);
            }

            // foreach to print out members of queue
            foreach( int x in numberQueue)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("numberQueue count is: " + numberQueue.Count);
            Console.WriteLine();

            // print a peek at the top of the stack
            Console.WriteLine("Element at the top of numbers is: " + numberQueue.Peek());
            Console.WriteLine();

            // loop that dequeues the elemnts from stack and prints each
            size = numberQueue.Count;
            Console.WriteLine("Print while dequeueing");
            for (int i=0; i < size; i++)
            {
                Console.WriteLine(numberQueue.Dequeue());
            }
            Console.WriteLine();

            // use a queue count and foreach loop to verify dequeue
            Console.WriteLine("Verify that all was dequeued:");
            Console.WriteLine("numberQueue count is: " + numberQueue.Count);
            foreach (int x in numberQueue)
            {
                Console.WriteLine(x);
            }
            #endregion
        }
    }
}
