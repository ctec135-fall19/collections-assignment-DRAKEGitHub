/* 
 Author: Allison Drake
 CTEC 165 Fall 2019
 Programming Assignment 4 Problem 1
 
 All code in Main()
 Regions: Simple array and List<T>

 Simple array: array of int size 5
 - use a for loop to initialize it to the numbers 11-15
 - use a foreach loop to print out the values in the array

 List<T>: create a list of int
 - use a for loop to iniitalize the list to 21-25
 - use a foreach loop to print the values in the list
 - update the values in list to 31-35 using indexing
 - repeat the print using a for loop and indexing

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SIMPLE ARRAY
            // set array of int size 5
            int[] magicalIntArray = new int[5];

            // use a for loop to initialize it to 11-15
            Console.WriteLine("Values of magicalIntArrays are:");
            for (int i=0; i<magicalIntArray.Length; i++)
            {
                magicalIntArray[i] = (i + 11);
            }

            // use a foreach loop to print out the values of array
            foreach (int entry in magicalIntArray)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine();
            #endregion

            #region LIST<T>
            // create a list of ints for 5 numbers
            List<int> lameList = new List<int>();
            // print current list count
            Console.WriteLine("Count of list lameList is: {0}", lameList.Count);

            // for loop initialize list to 21-25
            for (int j = 0; j < 5; j++)
            {
                lameList.Add(j+21);
            }
            // use a foreach loop to print the values
            Console.WriteLine("Values of lameList are:");
            foreach (int entry in lameList)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine("Count of list lameList is: {0}", lameList.Count);
            Console.WriteLine();

            // update list to 31-35 using indexing
            lameList[0] = 31;
            lameList[1] = 32;
            lameList[2] = 33;
            lameList[3] = 34;
            lameList[4] = 35;

            // repeat print using for loop and indexing
            Console.WriteLine("NEW Values of lameList are:");
            for (int i=0; i<lameList.Count; i++)
            {
                Console.WriteLine(lameList[i]);
            }
            Console.WriteLine("Count of list lameList is: {0}", lameList.Count);
            Console.WriteLine();
            #endregion
        }
    }
}
