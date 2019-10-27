/* 
 Author: Allison Drake
 CTEC 165 Fall 2019
 Programming Assignment 4 Problem 4
 
 LINKED LIST
 Put all code in Main()
 - Demonstrate use of constructor taking an IEnumberable object
 -Create a string array having the first 5-10 words of your favorite song
 - Use it as the argument when constructing the LinkedList Object
 - Print out on a single line

 - Create a node variable and walk the list starting with the head, 
 process the node, then set the node variable to the next node in the list

 - create a node variable and walk the list to print out the values
 (the line printed should be the same as the one above)

 - Remove a word from the middle of the list
 - Print the list on a single line to demonstrate this
 - Add the word back in and print the list again to demonstrate its
 // RATM Bulls on Parade: The microphone explodes, shattering the molds
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Program
    {
        static void Main(string[] args)
        {
            // constructor taking an IEnumberable Object

            // create string array having the first 5-10 words of fav song
            Console.WriteLine("Bulls on Parade");
            Console.WriteLine("by Rage Against the Machine");
            string[] bulls = { "The", "microphone", "explodes,", "shattering",
                "the", "molds" };
            foreach (string i in bulls) 
            {
                Console.Write (i + " ");
            }            
            Console.WriteLine();
            Console.WriteLine();

            // use string bulls to construct linked list sentence
            LinkedList<string> sentence = new LinkedList<string>(bulls);

            //print our song in a single line
            Console.WriteLine("Rewritten using LinkedList sentence:");
            foreach (string x in sentence)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // establish node as first entry of sentence linked list
            Console.WriteLine("Traversal of Linked List");
            LinkedListNode<string> node = sentence.First;
            DisplayProperties(node);

            // cycle through the node to print the next node in value
            while (node != null)
            {
                Console.Write("{0} ", node.Value);
                node = node.Next;
            }
            Console.WriteLine();
            Console.WriteLine();

            // removed a single word from the center of list
            Console.WriteLine("Removed the word shattering:");
            sentence.Remove("shattering");
            foreach (string x in sentence)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // put the word shattering back
            Console.WriteLine("Put shattering back in after explodes,");
            sentence.AddAfter(sentence.Find("explodes,"), "shattering");
            foreach (string x in sentence)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

        }

        private static void DisplayProperties(LinkedListNode<string> lln)
        {
            if (lln.List == null)
                Console.WriteLine("     Not enough RAGE");
            else
                Console.WriteLine("     Node belongs to a linked list with " +
                    "{0} elements", lln.List.Count);

            if (lln.Previous == null)
                Console.WriteLine("     Previous node is null");
            else
                Console.WriteLine("     Value of previous node: {0}", 
                    lln.Previous.Value);

            if (lln.Next == null)
                Console.WriteLine("     Next node is null");
            else
                Console.WriteLine("     Value of next node: {0}", lln.Next.Value);
        }
    }
}
