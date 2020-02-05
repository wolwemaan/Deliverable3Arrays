using System;
/*
 * 
 * Watch the video posted in CANVAS on: Arrays

Review the source codes on the GitHub link. Then write the following program:

PROGRAM #1: Create a C# console application that demonstrates an Array with the following instructions:

1. Choose either type of array (Manually populated for Auto populated) seen in the example

2. The program doesn't ask the user anything, it will just run and execute code. No user input.

3. Have the program execute an array that is of size 25 elements.

4. Then, have the code simply display in the Console the following 25 times (Here is a sample of the output):
 */
//
// Author: Ettienne Voges
// Program Week 3 Array program
//
//
namespace Deliverable3Arrays
{
    class Program
    {
        public const int ELEMENTS_COUNT = 25;
        static void Main(string[] args)
        {
            int [] numbers = new int[ELEMENTS_COUNT];
            for (int i = 0; i < ELEMENTS_COUNT; i++)
            {
                numbers[i] = 1 + i;

                Console.Write("Element value = ");
                Console.WriteLine(numbers[i]);
            }
            
        }
    }
}
