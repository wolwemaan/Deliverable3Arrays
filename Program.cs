//
// Author: Ettienne Voges
// Program Week 4 Array program
//
// Demonstrates an Array
//
using System;

namespace Deliverable3Arrays
{
    class Program
    {
        // Set 25 as the number of elements.
        public const int ELEMENTS_COUNT = 25;
        static void Main(string[] args)
        {
            // Declare the array
            int [] numbers = new int[ELEMENTS_COUNT];
            for (int i = 0; i < ELEMENTS_COUNT; i++)
            {
                // For each iteration initialize that element (Starting at 0) with a number (Starting from 1) 
                numbers[i] = 1 + i;

                // Each iteration will provide a chance to write that element's value that have been initialize with an earlier statement. 
                Console.Write("Element value = ");
                Console.WriteLine(numbers[i]);
            }
            
        }
    }
}
