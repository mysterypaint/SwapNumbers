using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize program variables
            int numOne, numTwo, temp;

            // Ask the user for the first number to enter
            Console.Write("Please enter your first number: ");
            numOne = Convert.ToInt32(Console.ReadLine());

            // Ask the user for the second number to enter
            Console.Write("Please enter your second number: ");
            numTwo = Convert.ToInt32(Console.ReadLine());

            // Print the input numbers
            Console.WriteLine("\n---\nYou have entered:\nNum 1 - " + numOne + "\nNum 2 - " + numTwo + "\nPress any key to continue");

            // Wait for user input before moving on
            Console.ReadKey();

            // Swap the two numbers
            Console.Write("\n---\nSwapping... ");
            temp = numOne;
            numOne = numTwo;
            numTwo = temp;
            Console.WriteLine("Done!");

            // Print the swapped numbers
            Console.WriteLine("\n---\nNum 1 (Swapped) - " + numOne + "\nNum 2 (Swapped) - " + numTwo);

            // Wait for user input before closing the program
            Console.Write("\n---\nPress any key to exit");
            Console.ReadKey();
        }
    }
}