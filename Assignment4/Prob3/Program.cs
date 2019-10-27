/* 
 Author: Allison Drake
 CTEC 165 Fall 2019
 Programming Assignment 4 Problem 3
 
 DICTIONARY
 All code in Main()

 -Declare a dictionary and initialize it to create 3 entries:
 (1, "one"), (2, "two"), and (3, "three"). 
 Use a combination of initialization syntax, Add() and [] in your code
 - Add an additional entry: (99, "ninety-nine")
 - show use of enumterator/foreach loop to see all entries
 (print both key and value in foreach loop)
 - reassign the value of 99 to "99" using indexing notation (int to string)
 - Print the new value using indexing notation
 - Remove the 2 item and enumerate over the whole dictrionary to show it's gone

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare dictionary and initialize to 3 entries
            Dictionary<int, string> myDict = new Dictionary<int, string>();
            // initialize using add() and [] in code
            myDict.Add(1, "one");
            myDict[2] = ("two");
            myDict[3] = ("three");

            Console.WriteLine("Initial Dictionary myDict:");
            foreach (KeyValuePair<int, string> item in myDict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
            Console.WriteLine();

            // add an additional entry: (99, "nintey-nine")
            myDict[99] = ("ninety-nine");

            // use foreach to print key and value
            Console.WriteLine("Updated with 99 Dictionary myDict:");
            foreach (KeyValuePair<int, string> item in myDict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
            Console.WriteLine();

            //reassign 99 key a value of "99"
            myDict[99] = "99";
            Console.WriteLine("Key 99 has a value of: " + myDict[99]);
            Console.WriteLine();

            // remove the 2 index and enumerate
            myDict.Remove(2);
            Console.WriteLine("Updated with the 2 index removed from myDict:");
            foreach (KeyValuePair<int, string> item in myDict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
            Console.WriteLine();
        }
    }
}
