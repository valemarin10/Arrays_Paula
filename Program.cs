//
/* 
Author: Paula Marin
Date: 02/06/2020
Comments: This C# console application code demonstrates the use of
Arrays 
*/

using System;

namespace Arrays_Paula
{
    class Program
    {
        static void Main(string[] args)

        {
            // Handle errors
            try
            {
                // Initializing the array 
                int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 22, 23, 24, 25 };

                // Loop iterates through the array.
                foreach (int i in numbers)
                {
                    // Display message with array value.
                    Console.WriteLine("The element value is: " + i);
                }
                Console.WriteLine("_________________________________________");
                // Display message after element values have been displayed 
                Console.WriteLine();
                Console.WriteLine("the end! ");

                // Display message to inform user of exit.
                Console.WriteLine();
                Console.WriteLine("Press any key to exit the program...");

                //wait for the user to press a key to terminate
                Console.ReadKey(true);
            }
            catch
            {
                // Pause the program and wait for the user to press a key to terminate
                Console.ReadKey(true);
            }
        }

    }
}
